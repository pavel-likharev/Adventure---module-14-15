using UnityEngine;

public class Character_Player : Character
{
    [SerializeField] private InputManager _inputManager;

    protected override void Update()
    {
        base.Update();

        if (_inputManager.IsPressedUseItemKey)
        {
            _inventory.UseItem();
            _inputManager.ResetUseKeyKey();
        }
    }
}