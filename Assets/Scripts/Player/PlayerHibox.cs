using StarterAssets;
using UnityEngine;

public class PlayerHibox : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private PlayerEquip playerEquip;

    public Player Player => player;
    public PlayerEquip PlayerEquip => playerEquip;

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}