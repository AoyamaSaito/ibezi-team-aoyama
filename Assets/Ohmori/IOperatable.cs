using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵がいなくなった時に動作するギミック全般に実装する
/// </summary>
public interface IOperatable
{
    /// <summary>
    /// 現在の敵をすべて倒した時に呼ばれる。
    /// </summary>
    public void GimmickOperate();
}
