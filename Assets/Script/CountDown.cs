using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    private int time_int;
    public Text time_UI;
    public float timer = 1.0f;
    private float timer1;

    void Update()
    {
        timer -= Time.deltaTime;
        time_int = (int)timer + 7;
        if (timer <= -4.0f && timer>= -7.0f){
            time_UI.text = time_int + "";
        }
        if (timer <= -7.0f)
        {
            time_UI.text = "GO!";
        }
        if (timer <= -8.0f)
        {
            time_UI.text = null;
        }
    }
}
