using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Transform _equipPoint;

    [SerializeField] private Item itemSlot;

    public bool IsEmpty { 
        get 
        { 
            return itemSlot == null; 
        }
        private set 
        { 
        }
    }

    public void SetItemInSlot(Item item)
    {
        item.Equip(_equipPoint);
        itemSlot = item;
    }
}
