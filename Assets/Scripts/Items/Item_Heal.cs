using UnityEngine;

public class Item_Heal : Item
{
    [SerializeField] private int _value;

    public override bool CanEquip(GameObject owner) => owner.GetComponent<HealthCharacter>() != null;

    public override void UseEffect(GameObject target)
    {
        if (target.TryGetComponent(out HealthCharacter health))
        {
            health.AddHealth(_value);

            Debug.Log("Ёффект увеличени€ здоровь€ активирован");
        }
    }
}