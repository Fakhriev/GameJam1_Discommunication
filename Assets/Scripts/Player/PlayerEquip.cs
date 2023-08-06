using UnityEngine;

public class PlayerEquip: MonoBehaviour
{
    [SerializeField] private Transform equipBone;

    private EquipItem _equipedItem;

    public void Equip(EquipItem item)
    {
        if (_equipedItem != null)
            _equipedItem.UnEquip();

        item.transform.parent = equipBone;
        item.transform.ResetLocal();
        _equipedItem = item;
    }
}