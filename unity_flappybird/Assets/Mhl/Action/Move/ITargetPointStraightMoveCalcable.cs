using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 目標位置にまっすぐ移動する計算を行うインターフェース
/// </summary>
public interface ITargetPointStraightMoveCalcable {

    /// <summary>
    /// 移動目標の位置を設定
    /// </summary>
    /// <param name="position">目標の位置</param>
    void SetTarget(Vector3 position);

    /// <summary>
    /// 移動速度設定
    /// </summary>
    /// <param name="speed">移動速度</param>
    void SetSpeed(float speed);

    /// <summary>
    /// 移動計算
    /// </summary>
    /// <param name="elapsedTime">前回からの経過時間</param>
    /// <returns>移動後の位置</returns>
    Vector3 CalcMove(float elapsedTime);
}
