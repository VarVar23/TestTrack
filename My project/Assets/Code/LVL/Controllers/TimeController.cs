using System;

public class TimeController 
{
    private DateTime _startTime;
    private DateTime _endTime;

    public TimeController(PlayButtonView playButtonView, FinishView finishView, CheckDeathPlayerView checkDeathPlayerView)
    {
        playButtonView.PlayButton.onClick.AddListener(StartTime);
        checkDeathPlayerView.PlayerDeath += ResetTime;
        finishView.Finish += SaveTime;
    }

    private void StartTime() => _startTime = DateTime.Now;
    private void StopTime() => _endTime = DateTime.Now;

    private void SaveTime()
    {
        StopTime();
        float time = (_endTime.Hour - _startTime.Hour) * 3600 + (_endTime.Minute - _startTime.Minute) * 60 + (_endTime.Second - _startTime.Second);

        SaveData.Instance.ResultTime = time.ToString() + " секунд";
        SaveToJson.Instance.SaveToFile();
    }

    private void ResetTime()
    {
        SaveData.Instance.ResultTime = "";
        SaveToJson.Instance.SaveToFile();
    }
}
