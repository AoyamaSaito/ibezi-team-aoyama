using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Tooltip("現在のEnemyの数"), SerializeField]
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
            var go = GameObject.FindGameObjectsWithTag("Gimmick"); // ギミックにはGimmickというタグをつける

            foreach(var n in go)
            {
                var io = n.GetComponent<IOperatable>();

                io?.GimmickOperate();
            }
        }
    }
}
