public class ActiveResultController 
{
    private CheckDeathPlayerView _checkDeathPlayerView;
    private ResultButtonView _resultButtonView;
    private ResultPanelView _resultPanelView;
    private InputController _inputController;
    private FinishView _finishView;

    public ActiveResultController(ResultButtonView resultButtonView, ResultPanelView resultPanelView, 
        InputController inputController, FinishView finishView, CheckDeathPlayerView checkDeathPlayerView)
    {
        _checkDeathPlayerView = checkDeathPlayerView;
        _resultButtonView = resultButtonView;
        _resultPanelView = resultPanelView;
        _inputController = inputController;
        _finishView = finishView;

        Subscribe();
    }

    private void Subscribe()
    {
        _checkDeathPlayerView.PlayerDeath += ActiveResultPanel;
        _inputController.InputESC += DeactiveResultPanel;
        _resultButtonView.ResultButton.onClick.AddListener(ActiveResultPanel);
        _finishView.Finish += ActiveResultPanel;
    }

    private void ActiveResultPanel()
    {
        _resultPanelView.gameObject.SetActive(true);
    } 
    private void DeactiveResultPanel() => _resultPanelView.gameObject.SetActive(false);

}
