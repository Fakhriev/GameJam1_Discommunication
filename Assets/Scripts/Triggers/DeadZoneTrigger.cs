using UnityEngine;

public class DeadZoneTrigger : CollisionTrigger
{
    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        playerHibox.Player.Die(Vector3.zero);
    }
}
