using UnityEngine;
using TMPro;

public class ResultPanelView : MonoBehaviour
{
    [SerializeField] private TMP_Text _resultText;
    [SerializeField] private TMP_Text _timeText;

    public TMP_Text ResultText => _resultText;
    public TMP_Text TimeText => _timeText;
}
