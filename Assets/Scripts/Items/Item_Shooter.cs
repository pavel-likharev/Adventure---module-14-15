using UnityEngine;

public class Item_Shooter : Item
{
    [SerializeField] private Projectile _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;

    public override bool CanEquip(GameObject owner) => true;

    public override void UseEffect(GameObject target)
    {
        Projectile newProjectile = Instantiate(_projectilePrefab, _spawnPoint.position, _spawnPoint.rotation);
        newProjectile.Shoot(_spawnPoint);

        StartEffect();
        Debug.Log("Выстрел активирован");
    }
}