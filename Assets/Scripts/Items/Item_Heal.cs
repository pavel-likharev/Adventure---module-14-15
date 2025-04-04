using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Heal : Item
{
    [SerializeField] private int value;

    public int GetValue() => value;
}
