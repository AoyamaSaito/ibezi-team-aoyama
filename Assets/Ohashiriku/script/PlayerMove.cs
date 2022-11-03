using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _power = 30;
    [SerializeField]
    private float _torquePower = 30;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void Move()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = (transform.position - mousePosition).normalized * _power;
        _rb.AddForce(dir, ForceMode2D.Impulse);
        _rb.AddTorque(Random.Range(-1 * _torquePower, 1 * _torquePower), ForceMode2D.Impulse);

    }
}
