using UnityEngine;

public class PushBackTrigger : CollisionTrigger
{
    [SerializeField] private float pushForce;

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        Vector3 pushDirection = (playerHibox.transform.position - transform.position).normalized;
        playerHibox.Player.Die(pushDirection * pushForce);
    }
}