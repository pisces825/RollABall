using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    bool condition1 = true;
    bool condition2 = false;

    int a = 10;
    int b = 4;

    bool isRaining = true;
    bool hasUmbrella = true;

    // Start is called before the first frame update
    void Start()
    {
        // CheckCondition();
        if (condition1 && condition2) // false
        {
            Debug.Log("条件1と条件2はtrueです"); // falseのため表示されない
        }
        
        if (condition1 || condition2) // true
        {
            Debug.Log("条件1または条件2がtrueです"); // trueのため表示される
        }

        // 演習①
        if (a >= 10 && a != 15 && b <= 5)
        {
            // 条件を満たす処理  
        }

        // 演習②
        if (! isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("家を出る。");
        }
    }

    void CheckCondition()
    {
        // &&:論理積（AND）
        Debug.Log(condition1 && condition2);
        // ||:論理和（OR）
        Debug.Log(condition1 || condition2);
        // !:否定（NOT）
        Debug.Log(!condition1);
        // ^:排他的論理和（XOR）
        Debug.Log(condition1 ^ condition2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}