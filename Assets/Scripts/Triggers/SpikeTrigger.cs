using StarterAssets;
using System;
using UnityEngine;

public class SpikeTrigger : CollisionTrigger
{
    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        playerHibox.Player.Forced();
    }
}
