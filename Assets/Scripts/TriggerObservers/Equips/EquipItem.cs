using System;
using UnityEngine;

public class EquipItem : CollisionTrigger, IEquip
{
    [SerializeField] private GameObject unEquipedModel;
    [SerializeField] private GameObject equipedModel;

    private Transform _defaultParent;
    private Vector3 _startPosition;
    private bool _equiped;

    public Action OnEquiped;
    public Action OnUnEquiped;

    private void Start()
    {
        _defaultParent = transform.parent;
        _startPosition = transform.position;

        SetUnEquipedModel();
    }

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        if (_equiped)
            return;

        Equip(playerHibox);
    }

    private void Equip(PlayerHibox playerHibox)
    {
        _equiped = true;
        playerHibox.PlayerEquip.Equip(this);

        SetEquipedModel();
        OnEquiped?.Invoke();
    }

    private void SetEquipedModel()
    {
        unEquipedModel.SetActive(false);
        equipedModel.SetActive(true);
    }

    public void UnEquip()
    {
        _equiped = false;
        transform.parent = _defaultParent;
        transform.position = _startPosition;
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;

        SetUnEquipedModel();
        OnUnEquiped?.Invoke();
    }

    private void SetUnEquipedModel()
    {
        unEquipedModel.SetActive(true);
        equipedModel.SetActive(false);
    }
}

public interface IEquip
{

}