using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    GameObject _bullet;
    [SerializeField]
    Transform _muzzleTransform;

    /// <summary>
    /// �U�����ă��C�L���X�g�������H
    /// </summary>
    public void Attack()
    {
        //GameObject bullet = Instantiate(_bullet);
        //bullet.transform.position = _muzzleTransform.position;
    }
}
