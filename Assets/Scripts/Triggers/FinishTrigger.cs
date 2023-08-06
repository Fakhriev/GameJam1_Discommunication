using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FinishTrigger : CollisionTrigger
{
    public static event Action<PlayerHibox> LevelFinished;
    public static event Action<InputMapState> InputMapChanged;
    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        LevelFinished?.Invoke(playerHibox);
        InputMapChanged?.Invoke(InputMapState.NoInput);
    }
}
