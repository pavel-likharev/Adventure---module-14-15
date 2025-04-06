using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speedForce;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    public void Shoot(Transform direction)
    {
        _rigidbody.AddForce(direction.forward * _speedForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}