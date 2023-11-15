using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraInput : MonoBehaviour
{
    public float sensitivity = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 左クリックが押されている間
        if (Mouse.current.leftButton.isPressed)
        {
            // マウスの値(Vector2)を取得し、
            Vector2 delta = Mouse.current.delta.ReadValue();
            // CameraのTransformを動かす
            Camera.main.transform.Translate(new Vector3(delta.x, delta.y, 0) * sensitivity);
        }
    }
}
