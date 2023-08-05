using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private RagdollActivator ragdollActivator;
    [SerializeField] private PlayerHibox playerHibox;

    public void Die(Vector3 pushDirection)
    {
        playerHibox.Deactivate();
        ragdollActivator.ActivateRagdoll(pushDirection);
    }
}