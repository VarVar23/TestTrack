using UnityEngine;

[CreateAssetMenu(fileName = "ResultSO", menuName = "Config/ResultSO", order = 0)]
public class ResultSO : ScriptableObject
{
    [SerializeField] private string _defaultResultText;
    [SerializeField] private string _winResultText;
    [SerializeField] private string _loseResultText;

    public string DefaultResultText => _defaultResultText;
    public string WinResultText => _winResultText;
    public string LoseResultText => _loseResultText;
}

