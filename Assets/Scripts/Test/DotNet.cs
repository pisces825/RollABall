using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotNet : MonoBehaviour
{

    // ���K�@�E�A
    public Text DayText;
    public Text DayAddWeakText;
    // Start is called before the first frame update
    void Start()
    {
        ShowTime();

        // ���K�@�E�A
        DayText.text = DateTime.Now.ToString();
        DayAddWeakText.text = DateTime.Now.AddDays(7).ToString();
    }

    void ShowTime()
    {
        DateTime now = DateTime.Now; // ���̎��Ԃ��擾����
        Debug.Log(now); // ���̎��Ԃ��Q�[���ɕ\������
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}