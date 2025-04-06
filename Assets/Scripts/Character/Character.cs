using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected Inventory _inventory;
    protected HealthCharacter _healthCharacter;
    protected AnimationCharacter _animationCharacter;
    protected MoveController _moveController;

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