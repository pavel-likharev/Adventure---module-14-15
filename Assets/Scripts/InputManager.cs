using UnityEngine;

public class InputManager : MonoBehaviour
{
    private const string HorizontalInputKey = "Horizontal";
    private const string VerticalInputKey = "Vertical";
    private const KeyCode UseItemKeyCode = KeyCode.F;
    
    private float _moveDeadZone = 0.1f;

    public Vector3 UserInput { get; private set; }

    public bool IsPressedUseItemKey { get; private set; }

    private void Update()
    {
        UserInput = GetUserInput();

        if (HasPressedUseKeyKey())
            IsPressedUseItemKey = true;
    }

    public void ResetUseKeyKey() => IsPressedUseItemKey = false;

    public bool HasPressedUseKeyKey() => Input.GetKeyDown(UseItemKeyCode);

    public bool HasInput() => UserInput.magnitude > _moveDeadZone;

    public Vector3 GetUserInput() => new Vector3(Input.GetAxisRaw(HorizontalInputKey), 0, Input.GetAxisRaw(VerticalInputKey));
}