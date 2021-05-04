using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



    public class FuelManager : MonoBehaviour
    {
        public GameEvent OutOfFuel;
        public GameEvent endOfFuel;
        public GameEvent StartEngine;
        public FloatVariable currentFuel;
        public FloatReference fuelConsumptionRate;

        public bool refillFuel;
        public FloatReference fualCapacity;
    
      
    private void Start()
        {
        refillFuel = false;
        currentFuel.SetValue(fualCapacity);
       

        }
    private void Update()
    {
         ConsumeFuel();

    }


    public void ConsumeFuel()
        {
        if (currentFuel.Value <= 0f)
        {
            endOfFuel.Raise();
            if (refillFuel)
            {
                refillFuel = false;
                currentFuel.SetValue(fualCapacity);
                Debug.Log("Engine report: Refueling");
                //StartEngine.Raise();
            }
            else
            {
                Debug.Log("Engine report: no fuel");
                OutOfFuel.Raise(); 
            }  
        }
        else
        {
            currentFuel.ApplyChange(-fuelConsumptionRate.Value*Time.deltaTime);
        }
        
       }
    


}
