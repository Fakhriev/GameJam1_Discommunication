using UnityEngine;

public abstract class CollisionTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerHibox playerHibox))
        {
            OnPlayerCollided(playerHibox);
        }
    }

    protected abstract void OnPlayerCollided(PlayerHibox playerHibox);
}