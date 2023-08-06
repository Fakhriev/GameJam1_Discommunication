using UnityEngine;

public class PushTrigger : CollisionTrigger
{
    [SerializeField] private Vector3 pushDirection;

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        playerHibox.Player.Push(pushDirection);
    }
}