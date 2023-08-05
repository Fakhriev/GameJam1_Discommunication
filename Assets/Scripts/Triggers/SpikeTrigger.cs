using UnityEngine;

public class SpikeTrigger : CollisionTrigger
{
    [SerializeField] private float jumpForce = 10f;

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        playerHibox.Player.Forced(jumpForce);
    }
}
