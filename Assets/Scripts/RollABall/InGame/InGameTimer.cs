using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameTimer : MonoBehaviour
{
    public Text TimerText;
    private float timerTime = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTime < 0)
        {
            TimerText.text = "0";
        }
        else
        {
            TimerText.text = $"{timerTime -= Time.deltaTime}";
        }
    }
}
