public class StartPlayerPositionController 
{
    private CheckDeathPlayerView _checkDeathPlayerView;
    private FinishView _finishView;
    private InputController _inputController;
    private PlayerView _playerView;
    private PlayerSO _playerSO;

    public StartPlayerPositionController(CheckDeathPlayerView checkDeathPlayerView, FinishView finishView,
        InputController inputController, PlayerView playerView, PlayerSO playerSO)
    {
        _checkDeathPlayerView = checkDeathPlayerView;
        _finishView = finishView;
        _inputController = inputController;
        _playerView = playerView;
        _playerSO = playerSO;

        Subscribe();
    }

    private void Subscribe()
    {
        _checkDeathPlayerView.PlayerDeath += SetStartPlayerPosition;
        _finishView.Finish += SetStartPlayerPosition;
        _inputController.InputESC += SetStartPlayerPosition;
    }

    private void SetStartPlayerPosition()
    {
        _playerView.transform.position = _playerSO.PlayerStartPosition;
    }
}
