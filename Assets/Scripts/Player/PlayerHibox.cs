using UnityEngine;

public class PlayerHibox : MonoBehaviour
{
    [SerializeField] private Player player;

    public Player Player => player;

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}