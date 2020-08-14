using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mhl
{
    /// <summary>
    /// ゲームコントローラー定義
    /// </summary>
    public class GameControllerConstant
    {
        /// <summary>
        /// 方向キー定義
        /// </summary>
        public enum DirectionKey : int
        {
            Up,
            Down,
            Right,
            Left,
            RightUp,
            RightDown,
            LeftUp,
            LeftDown
        };

        /// <summary>
        /// ボタン定義
        /// </summary>
        public enum Button : int
        {
            A,
            B,
            X,
            Y
        };
    }
}
