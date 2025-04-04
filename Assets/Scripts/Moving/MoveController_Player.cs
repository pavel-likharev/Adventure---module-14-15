using UnityEngine;

public class MoveController_Player : MoveController
{
    private InputManager _inputManager;
    private CharacterController _characterController;

    private Vector3 _input;

    protected override void Awake()
    {
        base.Awake();

        _inputManager = GetComponent<InputManager>();
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (IsMoving = _inputManager.HasInput())
        {
            _input = _inputManager.UserInput;

            MoveTo(_input, _characterController);
            RotateTo(_input);
        }
    }
}
