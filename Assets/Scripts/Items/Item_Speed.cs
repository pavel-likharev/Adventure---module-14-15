using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Item_Speed : Item
{
    [SerializeField] private float _speedBoost;

    public override bool CanEquip(GameObject owner) => owner.GetComponent<MoveController>();

    public override void UseEffect(GameObject target)
    {
        if (target.TryGetComponent(out MoveController moveController))
        {
            moveController.BoostSpeed(_speedBoost);

            Debug.Log("Ёффект увеличени€ скорости активирован");
        }
    }
}