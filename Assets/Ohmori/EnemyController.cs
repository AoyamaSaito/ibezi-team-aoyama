using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour ,IDamageable
{
    [Tooltip("�U����������Layer"), SerializeField]
    LayerMask _hitLayer;
    [Tooltip("Ray��end�̃x�N�g��"), SerializeField]
    Vector2 _rayEnd;
    [Tooltip("�ˏo����e��Prefab"), SerializeField]
    GameObject _bullet;
    [Tooltip("�e�𔭎˂���Ƃ���Muzzle"), SerializeField]
    Transform _muzzleTransform;
    [Tooltip("�e�𔭎˂���Ԋu"), SerializeField]
    float _triggerDistance = 2;

    float _timer;
    EnemyManager _manager;


    private void Start()
    {
        _manager = FindObjectOfType<EnemyManager>();
        _manager.AddEnemyCount();
    }

    //�U�������
    private void Update()
    {
        _timer += Time.deltaTime;

        // ��ыZ�̍U���̃g���K�[�̐���
        RaycastHit2D hit = Physics2D.Linecast(this.transform.position, this.transform.position + (Vector3)_rayEnd, ~_hitLayer);
        Debug.DrawLine(this.transform.position, this.transform.position + (Vector3)_rayEnd, Color.red);

        // �U���͈͂�Player����������
        if (hit && _timer > _triggerDistance)
        {
            // �e�𔭎˂���
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
