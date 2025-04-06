using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;

    private void OnTriggerEnter(Collider other)
    {
        if (_inventory.IsEmpty == false)
            return;

        if (other.TryGetComponent(out Item item))
        {
            if (item.CanEquip(_inventory.GetOwner()))
            {
                _inventory.EquipItem(item);
            }
        }
    }
}