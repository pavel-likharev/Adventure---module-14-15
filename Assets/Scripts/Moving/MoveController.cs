using UnityEngine;

public abstract class MoveController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private Vector3 _startPosition;

    [field: SerializeField] public bool IsMoving { get; protected set; }

    protected virtual void Awake()
    {
        _startPosition = transform.position;
    }

    public void BoostSpeed(float value)
    {
        if (value < 0)
        {
            Debug.LogError("«начение увеличени€ скорости не может быть меньше 0");
            return;
        }

        _moveSpeed += value;
    }

    protected void MoveTo(Vector3 input, CharacterController characterController)
    {
        characterController.Move(input.normalized * _moveSpeed * Time.deltaTime);
    }

    protected void MoveTo(Vector3 input)
    {
        transform.Translate(input.normalized * _moveSpeed * Time.deltaTime, Space.World);
    }

    protected void RotateTo(Vector3 input)
    {
        Quaternion lookRotation = Quaternion.LookRotation(input.normalized);
        float step = _rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, step);
    }

    public void ResetPosition() => transform.position = _startPosition;
}