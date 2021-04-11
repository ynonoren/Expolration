

using UnityEngine;


    public class SimpleUnitHealth : MonoBehaviour
    {
        public FloatVariable HP;
        public FloatVariable decayRate;
        public bool ResetHP;
        public FloatReference StartingHP;
        public GameObject timer;
        private void Start()
        {
        if (ResetHP)
        HP.SetValue(StartingHP);
        timer.SetActive(true);
        }

      public void HealthDecay()
        {

       
        if (HP.Value <= 0f)
        {
          GetComponent<Rigidbody>().isKinematic=true;
          timer.SetActive(false);
        }
        else
        {
            HP.ApplyChange(decayRate);
        }
        
       }
    }
