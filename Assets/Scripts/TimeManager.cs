using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static bool gameIsPaused;

    public FloatVariable timeReaminingInDay;
    public FloatReference dayDuration;
    public IntVariable dayCount;
    
    
  
    // Start is called before the first frame update
    void Start()
    {
        dayCount.SetValue(0);
        timeReaminingInDay.ApplyChange(dayDuration.Value);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameIsPaused)
            {
               
                PauseGame();
            }
            else
            {
                UnPauseGame();
            }
           
          
            
        }

        
            
            CountDays();
        



    }

    void CountDays() {


        if (timeReaminingInDay.Value<= 0)
        {
            dayCount.Value++;
            Debug.Log(dayCount.Value + " Days has passed");
            timeReaminingInDay.ApplyChange(dayDuration.Value);
        }
        else
        {
            timeReaminingInDay.ApplyChange(-Time.deltaTime);

        }


    }

    public void PauseGame()
    {
        gameIsPaused = true;
        
            Time.timeScale = 0f;
            Debug.Log("time has paused");
       
    }
    
    public void UnPauseGame()
    {
        gameIsPaused = false;
        Time.timeScale = 1;
        Debug.Log("time has resumed");
    }
}
