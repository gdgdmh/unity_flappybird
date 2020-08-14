using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mhl
{

    /// <summary>
    /// Unityの入力をコントローラーとして扱うクラス
    /// </summary>
    public class GameController
    {
        public GameController()
        {
        }

        public void Update()
        {
        }

        /// <summary>
        /// 方向キーが押されたか
        /// </summary>
        /// <param name="key">対象の方向キー</param>
        /// <returns>対象の方向キーが押されている間trueが返される</returns>
        public bool IsPress(GameControllerConstant.DirectionKey key)
        {
            KeyCode keyCode1, keyCode2;
            ConvertDirectionKeyToUnityKeyCode(key, out keyCode1, out keyCode2);
            if (keyCode2 != KeyCode.None)
            {
                // 複数キーを使うケース
                if (UnityEngine.Input.GetKey(keyCode1) && UnityEngine.Input.GetKey(keyCode2))
                {
                    return true;
                }
                return false;
            }
            if (UnityEngine.Input.GetKey(keyCode1))
            {
                // 単一キーを使うケース
                return true;
            }
            return false;
        }

        /// <summary>
        /// ボタンが押されたか
        /// </summary>
        /// <param name="button">対象のボタン</param>
        /// <returns>対象のボタンがtrueなら押されている</returns>
        public bool IsButtonDown(GameControllerConstant.Button button)
        {
            KeyCode keyCode = ConvertButtonToUnityKeyCode(button);
            if (UnityEngine.Input.GetKeyDown(keyCode))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// ボタンが持ち上げられたか
        /// </summary>
        /// <param name="button">対象のボタン</param>
        /// <returns>trueなら持ち上げられた</returns>
        public bool IsButtonUp(GameControllerConstant.Button button)
        {
            KeyCode keyCode = ConvertButtonToUnityKeyCode(button);
            if (UnityEngine.Input.GetKeyUp(keyCode))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 方向キーからUnityのKeyCodeに変換
        /// </summary>
        /// <param name="key">対象の方向キー</param>
        /// <param name="key1">UnityEngineのKeyCode</param>
        /// <param name="key2">UnityEngineのKeyCode(複数のケースあり)</param>
        private void ConvertDirectionKeyToUnityKeyCode(GameControllerConstant.DirectionKey key, out KeyCode key1, out KeyCode key2)
        {
            key1 = KeyCode.None;
            key2 = KeyCode.None;
            switch (key)
            {
                case GameControllerConstant.DirectionKey.Up:
                    key1 = KeyCode.UpArrow;
                    break;
                case GameControllerConstant.DirectionKey.Down:
                    key1 = KeyCode.DownArrow;
                    break;
                case GameControllerConstant.DirectionKey.Right:
                    key1 = KeyCode.RightArrow;
                    break;
                case GameControllerConstant.DirectionKey.Left:
                    key1 = KeyCode.LeftArrow;
                    break;
                case GameControllerConstant.DirectionKey.RightUp:
                    key1 = KeyCode.RightArrow;
                    key2 = KeyCode.UpArrow;
                    break;
                case GameControllerConstant.DirectionKey.RightDown:
                    key1 = KeyCode.RightArrow;
                    key2 = KeyCode.DownArrow;
                    break;
                case GameControllerConstant.DirectionKey.LeftUp:
                    key1 = KeyCode.LeftArrow;
                    key2 = KeyCode.UpArrow;
                    break;
                case GameControllerConstant.DirectionKey.LeftDown:
                    key1 = KeyCode.LeftArrow;
                    key2 = KeyCode.DownArrow;
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// ボタンからUnityのKeyCodeに変換
        /// </summary>
        /// <param name="button">対象のボタン</param>
        /// <returns>UnityEngineのキーコード</returns>
        private KeyCode ConvertButtonToUnityKeyCode(GameControllerConstant.Button button)
        {
            switch (button)
            {
                case GameControllerConstant.Button.A:
                    return KeyCode.Space;
                // A以外は今の所使用しないので割り当てなしとしています
                // 必要があれば割り当てをしてください
                case GameControllerConstant.Button.B:
                    return KeyCode.None;
                case GameControllerConstant.Button.X:
                    return KeyCode.None;
                case GameControllerConstant.Button.Y:
                    return KeyCode.None;
                default:
                    return KeyCode.None;
            }
        }
    }
}
