using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーへのヒット通知
/// </summary>
public interface IHitPlayerObservable
{
    /// <summary>
    /// ヒットした
    /// </summary>
    /// <param name="tag">当たったギミック,敵のタグ</param>
    void Hit(string tag);

}
