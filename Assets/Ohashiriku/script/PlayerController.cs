using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    PlayerMove _playerMove;
    PlayerAttack _playerAttack;
    private void Start()
    {
        _playerAttack = GetComponent<PlayerAttack>();
        _playerMove = GetComponent<PlayerMove>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _playerAttack.Attack();
            _playerMove.Move();
        }
    }
}
