using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<EquipBodyPart> _equipBodyParts;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Item>(out Item item))
        {
            TryEquipItem(item);

        }
    }

    private void TryEquipItem(Item item)
    {
        BodyParts bodyPartOfItem = item.GetBodyPart();

        foreach (EquipBodyPart bodyPart in _equipBodyParts)
        {
            if (bodyPart.GetBodyPart() == bodyPartOfItem)
            {
                if (bodyPart.IsEmpty)
                    item.OnEquip(bodyPart);

                return;
            }
        }
    }
}
