using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public FloatVariable timeReaminingInDay;
    public FloatReference dayDuration;
    public IntVariable dayCount;
    public BoolVariable dayIsRunning;
    public BoolVariable playerInSattelment;
    public bool stopDayClock;
    // Start is called before the first frame update
    void Start()
    {
        dayCount.SetValue(0);
        timeReaminingInDay.SetValue(dayDuration.Value);
        dayIsRunning.SetValue(true);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (stopDayClock||playerInSattelment.Value)
        {
            dayIsRunning.ApplyChange(false);
            Debug.Log("time has paused");
        }
        else
        {
            dayIsRunning.ApplyChange(true);
            CountDays();
        }



    }

    void CountDays() {


        if (timeReaminingInDay.Value <= 0)
        {
            dayCount.Value++;
            Debug.Log(dayCount.Value + " Days has passed");
            timeReaminingInDay.SetValue(dayDuration);
        }
        else
        {
            timeReaminingInDay.ApplyChange(-Time.deltaTime);
        }


    }



}
