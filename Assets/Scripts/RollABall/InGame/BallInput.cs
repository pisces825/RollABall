using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 新しいInput Systemを使用して"W"キーの入力を検知
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("Wキーが押されました!");
        }
        // Wキーが押され続けている間
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Wキーが押され続けてます!");
        }

        // 演習①
        // Aキーが押され続けている間
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Aキーが押され続けてます!");
        }
        // Sキーが押され続けている間
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Sキーが押され続けてます!");
        }
        // Dキーが押され続けている間
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("Dキーが押され続けてます!");
        }

        // Wキーが離された瞬間だけ評価する
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            Debug.Log("Wキーが離されました!");
        }

        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Debug.Log($"マウスの座標: {mousePosition}");
    }
}