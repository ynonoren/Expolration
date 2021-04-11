using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class LineAnchorer: MonoBehaviour
{
    public List<GameObject> attachedObjects;
    public LineRenderer lineRenderer;

#if UNITY_EDITOR
    void Update()
    {
        if (Application.isEditor && !Application.isPlaying)
        {
            for (int i = 0; i < attachedObjects.Count; i++)
            {
                if (i < lineRenderer.positionCount && attachedObjects != null)
                { lineRenderer.SetPosition(i, transform.InverseTransformPoint(attachedObjects[i].transform.position)); }
            }
        }
    }
#endif
}
