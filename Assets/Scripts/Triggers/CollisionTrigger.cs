using System;
using UnityEngine;

public abstract class CollisionTrigger : MonoBehaviour
{
    public Action OnTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerHibox playerHibox))
        {
            OnPlayerCollided(playerHibox);
            OnTriggered?.Invoke();
        }
    }

    protected abstract void OnPlayerCollided(PlayerHibox playerHibox);
}