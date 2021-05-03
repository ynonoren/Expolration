using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : MonoBehaviour
{
    public FloatReference range;
    private LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    { 
        Collider[] coll = Physics.OverlapSphere(transform.position, range);
       
        for (int i = 0; i < coll.Length; i++)
        {
          if (coll[i].gameObject.GetComponent<Enemy>())
            {
                Vector3 pos = coll[i].gameObject.transform.position;
                float dist = Vector3.Distance(pos, transform.position);
                if (dist <= range)
                {
                    lr.positionCount=2;
                    lr.SetPosition(0, transform.position);
                    lr.SetPosition(1, pos);
                    transform.LookAt(coll[i].transform.position);
                }
                else
                {
                    lr.positionCount = 0;
                }

            }
        }
      
    }
}
