using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletController : MonoBehaviour
{
    [Tooltip("’e‚Ì‘¬“x"), SerializeField]
    float _speed;

    Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(Vector3.left * _speed, ForceMode2D.Impulse);
    }
}
