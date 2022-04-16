using UnityEngine;

public class Main : MonoBehaviour
{
    [Header("ViewsUI")]
    [SerializeField] private PlayButtonView _playButtonView;
    [SerializeField] private ResultButtonView _resultButtonView;
    [SerializeField] private ResultPanelView _resultPanelView;
    [SerializeField] private MenuPanelView _menuPanelView;

    [Header("ViewsLVL")]
    [SerializeField] private FinishView _finishView;
    [SerializeField] private PlayerView _playerView;
    [SerializeField] private CheckDeathPlayerView _checkDeathPlayerView;


    [Header("Config")]
    [SerializeField] private PlayerSO _playerSO;
    [SerializeField] private ResultSO _resultSO;

    #region ControllersUI

    private InputController _inputController;
    private LoadTrackController _loadTrackController;
    private ActiveMenuController _activeMenuController;
    private ActiveResultController _activeResultController;
    private SetResultController _setResultController;
    private TimeController _timeController;

    #endregion

    #region Save

    private SaveData _saveData;
    private SaveToJson _saveToJson;

    #endregion

    #region ControllersLVL

    private StartPlayerPositionController _startPlayerPositionController;
    private PlayerDeathController _playerDeathController;
    private PlayerMoveController _playerController;
    private FinishController _finishController;

    #endregion

    private void Awake()
    {
        AwakeInitialize();

        _saveToJson.Awake();
    }

    private void Start()
    {
        StartInitialize();
    }

    private void AwakeInitialize()
    {
        _inputController = new InputController();
        _saveToJson = new SaveToJson(_resultSO);
        _saveData = new SaveData();
    }

    private void StartInitialize()
    {
        _finishController = new FinishController(_finishView, _resultSO);
        _playerDeathController = new PlayerDeathController(_checkDeathPlayerView, _resultSO);
        _timeController = new TimeController(_playButtonView, _finishView, _checkDeathPlayerView);
        _loadTrackController = new LoadTrackController(_playButtonView, _menuPanelView);
        _activeMenuController = new ActiveMenuController(_inputController, _menuPanelView);
        _activeResultController = new ActiveResultController(_resultButtonView, _resultPanelView, _inputController, _finishView, _checkDeathPlayerView);
        _setResultController = new SetResultController(_resultButtonView, _resultPanelView, _finishView, _checkDeathPlayerView);
        _playerController = new PlayerMoveController(_inputController, _playerView, _playerSO);
        _startPlayerPositionController = new StartPlayerPositionController(_checkDeathPlayerView, _finishView, _inputController, _playerView, _playerSO);
    }

    private void FixedUpdate()
    {
        _playerController.FixedUpdate();
    }

    private void Update()
    {
        _inputController?.Update();
    }
}
