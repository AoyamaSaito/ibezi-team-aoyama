using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour ,IDamageable
{
    [Tooltip("UŒ‚”»’è‚ğæ‚éLayer"), SerializeField]
    LayerMask _hitLayer;
    [Tooltip("Ray‚Ìend‚ÌƒxƒNƒgƒ‹"), SerializeField]
    Vector2 _rayEnd;
    [Tooltip("Ëo‚·‚é’e‚ÌPrefab"), SerializeField]
    GameObject _bullet;
    [Tooltip("’e‚ğ”­Ë‚·‚é‚Æ‚«‚ÌMuzzle"), SerializeField]
    Transform _muzzleTransform;
    [Tooltip("’e‚ğ”­Ë‚·‚éŠÔŠu"), SerializeField]
    float _triggerDistance = 2;

    float _timer;
    EnemyManager _manager;


    private void Start()
    {
        _manager = FindObjectOfType<EnemyManager>();
        _manager.AddEnemyCount();
    }

    //UŒ‚‚ğì‚é
    private void Update()
    {
        _timer += Time.deltaTime;

        // ”ò‚Ñ‹Z‚ÌUŒ‚‚ÌƒgƒŠƒK[‚Ì¶¬
        RaycastHit2D hit = Physics2D.Linecast(this.transform.position, this.transform.position + (Vector3)_rayEnd, ~_hitLayer);
        Debug.DrawLine(this.transform.position, this.transform.position + (Vector3)_rayEnd, Color.red);

        // UŒ‚”ÍˆÍ‚ÉPlayer‚ª“ü‚Á‚½‚ç
        if (hit && _timer > _triggerDistance)
        {
            // ’e‚ğ”­Ë‚·‚é
            GameObject ibullet = Instantiate(_bullet);
            ibullet.transform.position = _muzzleTransform.position;

            _timer = 0;
        }
    }


    public void AttackEnemy()
    {
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        _manager.RemoveEnemyCount();
    }
}
