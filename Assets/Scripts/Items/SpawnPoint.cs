using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Item Item { get; private set; }

    public bool IsEmpty
    {
        get
        {
            if (Item == null)
                return true;

            if (Item.gameObject == null)
                return true;

            return false;
        }
    }

    public Vector3 GetPosition() => transform.position;

    public void Occupy(Item item)
    {
        item.transform.SetParent(transform);
        Item = item;
    }
}