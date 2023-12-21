using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeIdleWalkingState : MonoBehaviour
{

    private Animator remyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        this.remyAnimator = this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーがエンターされると
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // トリガーパラメータ名を指定してトリガーをオンにする
            this.remyAnimator.SetTrigger("ChangeIdleWalkingState");
        }
    }
}