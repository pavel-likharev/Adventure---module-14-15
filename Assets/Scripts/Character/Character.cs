using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private List<EquipBodyPart> _equipBodyParts;

    private Inventory _inventory;
    private HealthCharacter _healthCharacter;
    private AnimationCharacter _animationCharacter;
    private MoveController _moveController;

    protected virtual void Awake()
    {
        _healthCharacter = GetComponent<HealthCharacter>();
        _inventory = GetComponent<Inventory>();
        _animationCharacter = GetComponent<AnimationCharacter>();
        _moveController = GetComponent<MoveController>();
    }

    protected virtual void Update()
    {
        Animate();
    }

    private void Animate()
    {
        _animationCharacter.IsMoving = _moveController.IsMoving;
    }

    public virtual void Reset()
    {
        _moveController.ResetPosition();
        _animationCharacter.Restart();
    }

    public void MakeLoser() => _animationCharacter.StartDeathClip();

    public void MakeWinner() => _animationCharacter.StartWinClip();
}
