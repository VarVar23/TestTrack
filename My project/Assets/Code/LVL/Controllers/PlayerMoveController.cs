using UnityEngine;

public class PlayerMoveController 
{
    private InputController _inputController;
    private PlayerView _playerView;
    private PlayerSO _playerSO;
    private Vector3 _move;

    public PlayerMoveController(InputController inputController, PlayerView playerView, PlayerSO playerSO)
    {
        _inputController = inputController;
        _playerView = playerView;
        _playerSO = playerSO;
    }

    public void FixedUpdate()
    {
        _move = new Vector3(_inputController.Horizontal, Physics.gravity.y, _inputController.Vertical) * _playerSO.PlayerSpeed;
        _playerView.PlayerRigidbody.velocity = _move;
    }
}
