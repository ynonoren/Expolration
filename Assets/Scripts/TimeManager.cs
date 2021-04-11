using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public FloatVariable gameDay;
    public FloatReference dayDuration;
    public FloatVariable dayCount;
    public BoolVariable dayIsRunning;
    public bool stopDayClock;
    // Start is called before the first frame update
    void Start()
    {
        dayCount.Value = 0;
        gameDay.SetValue(dayDuration.Value);
    }

    // Update is called once per frame
    void Update()
    {

        if (stopDayClock)
        {
            dayIsRunning.ApplyChange(false);
        }
        else
        {
            dayIsRunning.ApplyChange(true);
            CountDays();
        }



    }

    void CountDays() {


        if (gameDay.Value <= 0)
        {
            dayCount.Value++;
            Debug.Log(Mathf.Floor(dayCount.Value) + " Days has passed");
            gameDay.SetValue(dayDuration);
        }
        else
        {
            gameDay.ApplyChange(-Time.deltaTime);
        }


    }



}
