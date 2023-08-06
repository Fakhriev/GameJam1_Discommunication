using StarterAssets;
using UnityEngine;

public class Player : MonoBehaviour, IService
{
    [SerializeField] private RagdollActivator ragdollActivator;
    [SerializeField] private PlayerHibox playerHibox;
    [SerializeField] private ThirdPersonController thirdPersonController;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Rigidbody pushRb;

    public void Die(Vector3 pushDirection)
    {
        playerHibox.Deactivate();
        ragdollActivator.ActivateRagdoll(pushDirection);
    }

    public void Push(Vector3 pushDirection)
    {
        characterController.enabled = false;
        pushRb.AddForce(pushDirection, ForceMode.Impulse);
        characterController.enabled = true;
    }

    public void Forced(float force)
    {
        thirdPersonController.ForceJump(force);
    }

    public void SetPosition(Vector3 position)
    {
        characterController.enabled = false;
        transform.position = position;
        characterController.enabled = true;
    }
}