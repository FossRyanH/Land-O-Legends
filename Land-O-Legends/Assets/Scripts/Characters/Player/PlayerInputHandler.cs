using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    PlayerInputs _inputActions;
    PlayerController _player;

    void Awake()
    {
        _player = GetComponent<PlayerController>();
    }

    void OnEnable()
    {
        if (_inputActions == null)
        {
            _inputActions = new PlayerInputs();
            _inputActions.PlayerActions.Move.performed += i => _player.HandleMoveInput(i.ReadValue<Vector2>());
            _inputActions.PlayerActions.Sprint.performed += s => _player.HandleSprintInput();
        }
        _inputActions.Enable();
    }
}
