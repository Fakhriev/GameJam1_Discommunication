using StarterAssets;
using UnityEngine;

public class Player : MonoBehaviour, IService
{
    [SerializeField] private RagdollActivator ragdollActivator;
    [SerializeField] private PlayerHibox playerHibox;
    [SerializeField] private ThirdPersonController thirdPersonController;
    private const float PowerTrampoline = 5f;
    public void Die(Vector3 pushDirection)
    {
        playerHibox.Deactivate();
        ragdollActivator.ActivateRagdoll(pushDirection);
    }
    public void Forced()
    {
        thirdPersonController.ForceJump(PowerTrampoline);
    }
}