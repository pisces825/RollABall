using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalOperations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IfStatement();
    }

    void IfStatement()
    {
        bool conditionTrue = true;
        bool conditionFalse = false;

        // if(条件): 条件がtrueの時、次の処理を行う
        if (conditionTrue)
        {
            Debug.Log("trueのためこの処理が呼び出されます");
        }
        if (conditionFalse)
        {
            Debug.Log("falseのためこの処理は呼び出されません");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}