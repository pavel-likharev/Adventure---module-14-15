using UnityEngine;

public class HealthCharacter : MonoBehaviour
{
    [SerializeField] private int _startHealth;

    [field: SerializeField] public int Health { get; private set; }

    public bool IsDead { get; private set; }

    private void Awake()
    {
        Health = _startHealth;

        IsDead = false;
    }

    public void AddHealth(int value)
    {
        if (value < 0)
        {
            Debug.LogError("Значение не может быть меньше нуля");
            return;
        }

        Health += value;
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.LogError("Урон не может быть меньше нуля");
            return;
        }

        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
            IsDead = true;
        }
    }
}