using System.Collections;
using UnityEngine;

public class SlowTrigger : CollisionTrigger
{
    [SerializeField] private float slowMultiplyier;
    [SerializeField] private float slowTime;

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        playerHibox.Player.StartCoroutine(SlowPlayer(playerHibox));
        gameObject.SetActive(false);
    }

    private IEnumerator SlowPlayer(PlayerHibox playerHibox)
    {
        playerHibox.Player.Slow(slowMultiplyier);
        yield return new WaitForSeconds(slowTime);
        playerHibox.Player.NormalizeSpeed();
    }
}