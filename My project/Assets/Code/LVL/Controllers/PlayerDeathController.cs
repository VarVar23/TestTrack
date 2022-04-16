public class PlayerDeathController 
{
    private ResultSO _resultSO;

    public PlayerDeathController(CheckDeathPlayerView checkDeathPlayerView, ResultSO resultSO)
    {
        _resultSO = resultSO;

        checkDeathPlayerView.PlayerDeath += SetResult;
    }

    private void SetResult()
    {
        SaveData.Instance.ResultText = _resultSO.LoseResultText;
        SaveToJson.Instance.SaveToFile();
    }
}
