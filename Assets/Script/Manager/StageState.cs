using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stageの状態(ライフ、スコア)を管理するクラス
/// </summary>
public class StageState
{
    public int Life { get; private set; }

    public int Score { get; private set; }

    public StageState()
    {
        
    }

    /// <summary>
    /// Stageの初期化処理
    /// </summary>
    /// <param name="life"></param>
    public void Init(int life)
    {
        Life = life;
        Score = 0;
    }

    /// <summary>
    /// HPに変更を加える
    /// </summary>
    /// <param name="value"></param>
    public void ChangeLife(int value)
    {
        Life += value;

        //HPが0以下になると死亡時の関数を呼ぶ
        if(Life <= 0)
        {
            Death();
        }
    }

    /// <summary>
    /// Scoreに変更を加える
    /// </summary>
    /// <param name="value"></param>
    public void ChangeScore(int value)
    {
        Score += value;
    }

    /// <summary>
    /// プレイヤーが死亡したときの処理
    /// </summary>
    private void Death()
    {

    }
}
