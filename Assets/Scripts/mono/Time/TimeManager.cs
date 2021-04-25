using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static bool gameIsPaused;

    public float timeReaminingInDay;
    public FloatReference dayDuration;
    public IntVariable dayCount;
    
    
  
    // Start is called before the first frame update
    void Start()
    {
        dayCount.SetValue(0);
        timeReaminingInDay=dayDuration.Value;
        
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


        if (timeReaminingInDay<= 0)
        {
            dayCount.Value++;
            Debug.Log(dayCount.Value + " Days has passed");
            timeReaminingInDay=dayDuration.Value;
        }
        else
        {
            timeReaminingInDay-=Time.deltaTime;

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
