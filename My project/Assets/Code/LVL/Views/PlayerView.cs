using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Rigidbody _playerRigidbody;
    public Rigidbody PlayerRigidbody => _playerRigidbody;
}
