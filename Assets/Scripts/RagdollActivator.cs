using StarterAssets;
using UnityEngine;

public class RagdollActivator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private ThirdPersonController thirdPersonController;

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
    }
}