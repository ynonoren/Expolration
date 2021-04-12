using System.Collections;
using System.Collections.Generic;

using UnityEngine;


    public class FuelManager : MonoBehaviour
    {
        public FloatVariable currentFuel;
        public FloatReference fuelConsumptionRate;

        public bool refillFuel;
        public FloatReference fualCapacity;
        public BoolVariable dayIsRunning;
        public BoolVariable outOfFuel;
    private void Start()
        {

        currentFuel.SetValue(fualCapacity);
        outOfFuel.SetValue(false);

        }
    private void Update()
    {
        if (dayIsRunning.Value)
        {
            ConsumeFuel();
        }
    }





    public void ConsumeFuel()
        {

       
        if (currentFuel.Value <= 0f)
        {
            if (refillFuel)
            {
                currentFuel.SetValue(fualCapacity);
              
                outOfFuel.SetValue(false);
            }
            else
            {
             
                outOfFuel.SetValue(true);
            }
         
         
        }
        else
        {
            currentFuel.ApplyChange(-fuelConsumptionRate.Value/100);
        }
        
       }
    }
