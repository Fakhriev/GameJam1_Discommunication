using System;
using UnityEngine;

public abstract class CollisionTrigger : MonoBehaviour
{
    public Action OnTriggered;
    public Action OnUntrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerHibox playerHibox))
        {
            OnPlayerCollided(playerHibox);
            OnTriggered?.Invoke();
        }
    }

    protected abstract void OnPlayerCollided(PlayerHibox playerHibox);

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out PlayerHibox playerHibox))
        {
            OnPlayerUncollided(playerHibox);
            OnUntrigger?.Invoke();
        }
    }

    protected virtual void OnPlayerUncollided(PlayerHibox playerHibox)
    {

    }
}