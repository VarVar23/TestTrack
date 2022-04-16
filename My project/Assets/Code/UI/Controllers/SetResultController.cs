public class SetResultController
{
    private CheckDeathPlayerView _checkDeathPlayerView;
    private ResultButtonView _resultButtonView;
    private ResultPanelView _resultPanelView;
    private FinishView _finishView;

    public SetResultController(ResultButtonView resultButtonView, ResultPanelView resultPanelView, FinishView finishView,
        CheckDeathPlayerView checkDeathPlayerView)
    {
        _checkDeathPlayerView = checkDeathPlayerView;
        _resultButtonView = resultButtonView;
        _resultPanelView = resultPanelView;
        _finishView = finishView;

        Subscribe();
    }

    private void Subscribe()
    {
        _resultButtonView.ResultButton.onClick.AddListener(SetResult);
        _checkDeathPlayerView.PlayerDeath += SetResult;
        _finishView.Finish += SetResult;
    }

    private void SetResult()
    {
        _resultPanelView.ResultText.text = SaveData.Instance.ResultText;
        _resultPanelView.TimeText.text = SaveData.Instance.ResultTime;
    }
}