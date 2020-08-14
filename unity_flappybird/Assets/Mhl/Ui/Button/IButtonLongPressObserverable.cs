using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mhl
{
    /// <summary>
    /// ボタン長押し通知インターフェース
    /// </summary>
    public interface IButtonLongPressObserverable
    {
        /// <summary>
        /// 長押しの開始
        /// </summary>
        /// <param name="eventData">押し始めのイベントパラメーター</param>
        /// <param name="parameter">識別のためのパラメーター</param>
        void StartLongPress(PointerEventData eventData, int parameter);

        /// <summary>
        /// 長押しの終了
        /// </summary>
        /// <param name="eventData">押し終わりのイベントパラメータ</param>
        /// <param name="parameter">識別のためのパラメーター</param>
        void EndLongPress(PointerEventData eventData, int parameter);

        /// <summary>
        /// 長押ししている時に呼ばれる
        /// </summary>
        /// <param name="parameter">識別のためのパラメーター</param>
        void LongPress(int parameter);
    }
}
