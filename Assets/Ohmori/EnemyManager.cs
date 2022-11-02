using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Tooltip("���݂�Enemy�̐�"), SerializeField]
    int _currentEnemyCount;

    public void AddEnemyCount()
    {
        _currentEnemyCount++;
    }

    public void RemoveEnemyCount()
    {
        _currentEnemyCount--;

        if (_currentEnemyCount <= 0)
        {
            var go = GameObject.FindGameObjectsWithTag("Gimmick"); // �M�~�b�N�ɂ�Gimmick�Ƃ����^�O������

            foreach(var n in go)
            {
                var io = n.GetComponent<IOperatable>();

                io?.GimmickOperate();
            }
        }
    }
}
