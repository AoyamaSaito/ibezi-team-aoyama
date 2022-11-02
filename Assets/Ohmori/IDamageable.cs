using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemyが攻撃を受ける処理を実装するインターフェース
/// </summary>
public interface IDamageable
{
    /// <summary>
    /// Enemyを攻撃するときに呼ぶ
    /// </summary>
    public void AttackEnemy();
}