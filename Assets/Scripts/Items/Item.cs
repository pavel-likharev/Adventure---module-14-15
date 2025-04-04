using UnityEditor;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private float _equipEffectSpeed = 1;

    [SerializeField] private BodyParts bodyPart;

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
        _rotateCurrentSide = Random.Range(0, 2) == 0 ?  _rotateLeftSide : _rotateRightSide; 
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

    public void OnEquip(EquipBodyPart equipBodyPart)
    {
        

        transform.SetParent(equipBodyPart.transform);

        _isEquip = true;
    }

    public BodyParts GetBodyPart() => bodyPart;
}
