using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Transform _equipPoint;
    [SerializeField] private GameObject _owner;

    private Item _itemSlot;

    public GameObject GetOwner() => _owner;
    
    public bool IsEmpty => _itemSlot == null;

    public void EquipItem(Item item)
    {
        item.Equip(_equipPoint);
        _itemSlot = item;
    }

    public void UseItem()
    {
        if (IsEmpty)
        {
            Debug.Log("Инвентарь пуст!");
            return;
        }

        _itemSlot.UseEffect(_owner);
        Destroy(_itemSlot.gameObject);
        _itemSlot = null;
    }
}