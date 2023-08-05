using StarterAssets;
using System.Collections.Generic;
using UnityEngine;

public class RagdollActivator : MonoBehaviour
{
    [Header("Controllers")]
    [SerializeField] private Animator animator;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private ThirdPersonController thirdPersonController;

    [Header("Rigidbody")]
    [SerializeField] private new Rigidbody rigidbodyToPush;
    [SerializeField] private Vector3 pushDirection;

    [Header("Colliders")]
    [SerializeField] private RadgollComponent[] ragdollComponents;
    [SerializeField] private Transform skeleton;
    [SerializeField] private bool validate;

    private void OnValidate()
    {
        if (validate == false)
            return;

        List<RadgollComponent> ragdols = new List<RadgollComponent>();
        Collider[] colliders = skeleton.GetComponentsInChildren<Collider>();

        foreach (var coll in colliders)
        {
            if(coll.gameObject.TryGetComponent(out Rigidbody rb))
            {
                RadgollComponent ragdollComponent = new RadgollComponent(coll, rb);
                ragdols.Add(ragdollComponent);
                ragdollComponent.Deactivate();
            }
        }

        ragdollComponents = ragdols.ToArray();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
            ActivateRagdoll();
    }

    private void ActivateRagdoll()
    {
        animator.enabled = false;
        characterController.enabled = false;
        thirdPersonController.enabled = false;

        foreach (var ragComp in ragdollComponents)
        {
            ragComp.Activate();
        }

        rigidbodyToPush.AddForce(pushDirection, ForceMode.Impulse);
    }
}

[System.Serializable]
public class RadgollComponent
{
    public Collider collider;
    public Rigidbody rigidbody;

    public RadgollComponent(Collider collider, Rigidbody rigidbody)
    {
        this.rigidbody = rigidbody;
        this.collider = collider;
    }

    public void Deactivate()
    {
        collider.enabled = false;
        rigidbody.isKinematic = true;
    }

    public void Activate()
    {
        collider.enabled = true;
        rigidbody.isKinematic = false;
        rigidbody.velocity = Vector3.zero;
    }
}