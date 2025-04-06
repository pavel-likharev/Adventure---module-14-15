using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private Vector3 _equipPositionOffset;
    [SerializeField] private Vector3 _equipRotationOffset;

    [SerializeField] protected ParticleSystem _particleEffect;

    private float _rotateSpeed = 15;

    private int _rotateRightSide = -1;
    private int _rotateLeftSide = 1;
    private int _rotateCurrentSide;

    private bool _isEquip;

    private void Awake()
    {
        _isEquip = false;
    }

    private void Start()
    {
        _rotateCurrentSide = Random.Range(0, 2) == 0 ? _rotateLeftSide : _rotateRightSide;
    }

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        if (_isEquip == false)
            transform.Rotate(transform.up, _rotateSpeed * _rotateCurrentSide * Time.deltaTime);
    }

    public void Equip(Transform equipPoint)
    {
        transform.SetParent(equipPoint);
        transform.localPosition = _equipPositionOffset;
        transform.localRotation = Quaternion.Euler(_equipRotationOffset);

        _isEquip = true;
    }

    protected void StartEffect()
    {
        _particleEffect.transform.parent = null;
        _particleEffect.Play();
    }

    public abstract bool CanEquip(GameObject owner);

    public abstract void UseEffect(GameObject target);
}