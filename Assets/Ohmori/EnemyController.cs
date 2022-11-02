using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour ,IDamageable
{
    [Tooltip("攻撃判定を取るLayer"), SerializeField]
    LayerMask _hitLayer;
    [Tooltip("Rayのendのベクトル"), SerializeField]
    Vector2 _rayEnd;
    [Tooltip("射出する弾のPrefab"), SerializeField]
    GameObject _bullet;
    [Tooltip("弾を発射するときのMuzzle"), SerializeField]
    Transform _muzzleTransform;
    [Tooltip("弾を発射する間隔"), SerializeField]
    float _triggerDistance = 2;

    float _timer;
    EnemyManager _manager;


    private void Start()
    {
        _manager = FindObjectOfType<EnemyManager>();
        _manager.AddEnemyCount();
    }

    //攻撃を作る
    private void Update()
    {
        _timer += Time.deltaTime;

        // 飛び技の攻撃のトリガーの生成
        RaycastHit2D hit = Physics2D.Linecast(this.transform.position, this.transform.position + (Vector3)_rayEnd, ~_hitLayer);
        Debug.DrawLine(this.transform.position, this.transform.position + (Vector3)_rayEnd, Color.red);

        // 攻撃範囲にPlayerが入ったら
        if (hit && _timer > _triggerDistance)
        {
            // 弾を発射する
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
