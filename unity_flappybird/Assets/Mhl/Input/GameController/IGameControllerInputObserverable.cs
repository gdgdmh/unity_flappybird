using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mhl
{
    /// <summary>
    /// ゲームコントローラー入力オブザーバーインターフェース
    /// </summary>
    public interface IGameControllerInputObserverable
    {
        /// <summary>
        /// 方向キーが押されている
        /// </summary>
        /// <param name="key">方向キー</param>
        void PressDirectionKey(GameControllerConstant.DirectionKey key);

        /// <summary>
        /// ボタンの押下
        /// </summary>
        /// <param name="button">ボタン</param>
        void ButtonDown(GameControllerConstant.Button button);
    }
}
