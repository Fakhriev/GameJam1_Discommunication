using UnityEngine;

public class Teleporter : CollisionTrigger
{
    [SerializeField] private Transform teleportTransform;

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        playerHibox.Player.SetPosition(teleportTransform.position);
    }
}