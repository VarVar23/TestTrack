using UnityEngine;

public class FinishController 
{
    private ResultSO _resultSO;

    public FinishController(FinishView finishView, ResultSO resultSO)
    {
        _resultSO = resultSO;

        finishView.Finish += SetResult;
    }

    private void SetResult()
    {
        SaveData.Instance.ResultText = _resultSO.WinResultText;
        SaveToJson.Instance.SaveToFile();
    }
}
