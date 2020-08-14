using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mhl;

namespace Mhl
{
    /// <summary>
    /// ゲームコントローラー入力サブジェクト
    /// </summary>
    public class GameControllerInputSubject : GenericSubject<Mhl.IGameControllerInputObserverable>
    {
        /// <summary>
        /// 方向キープレスイベント通知
        /// </summary>
        /// <param name="key">方向キー</param>
        public void NotifyObserversPressDirectionKey(GameControllerConstant.DirectionKey key)
        {
            foreach (var observer in observers)
            {
                observer.PressDirectionKey(key);
            }
        }

        /// <summary>
        /// ボタン押下イベント通知
        /// </summary>
        public void NotifyObserversButton(GameControllerConstant.Button button)
        {
            foreach (var observer in observers)
            {
                observer.ButtonDown(button);
            }
        }
    }
}
