using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Config/PlayerSO", order = 0)]
public class PlayerSO : ScriptableObject
{
    [SerializeField] private Vector3 _playerStartPosition;
    [SerializeField] private float _playerSpeed;

    public Vector3 PlayerStartPosition => _playerStartPosition;
    public float PlayerSpeed => _playerSpeed;
}

