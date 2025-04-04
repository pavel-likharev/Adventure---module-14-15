using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemsCollector : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Item>(out Item item))
        {
            if (_inventory.IsEmpty)
                EquipItem(item);
        }
    }

    private void EquipItem(Item item) => _inventory.SetItemInSlot(item);
    
}
