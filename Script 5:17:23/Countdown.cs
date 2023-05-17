using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Slider CDSlider;
    public float TimeRemaining;
    public float TimerMax;

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = TimerMax;
    }

    // Update is called once per frame
    void Update()
    {
        CDSlider.value = TimeRemaining / TimerMax;

        if(TimeRemaining > 0)
        {
            TimeRemaining -= Time.deltaTime;
        }
    }
}
