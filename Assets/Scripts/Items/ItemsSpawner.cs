using System.Collections.Generic;
using UnityEngine;

public class ItemsSpawner : MonoBehaviour
{
    [SerializeField] private List<Item> _itemPrefabs;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    [SerializeField] private Vector3 _spawnOffsetPosition;

    private void Awake()
    {
        _spawnPoints = new();

        foreach (Transform child in transform)
            _spawnPoints.Add(child.gameObject.GetComponent<SpawnPoint>());
    }

    private void Start()
    {
        SpawnRandomItems();
    }

    private void SpawnRandomItems()
    {
        foreach (SpawnPoint point in _spawnPoints)
        {
            Vector3 spawnPosition = point.GetPosition() + _spawnOffsetPosition;
            Item newItem = Instantiate(_itemPrefabs[Random.Range(0, _itemPrefabs.Count)], spawnPosition, Quaternion.identity);
            
            point.Occupy(newItem);
        }
    }
}