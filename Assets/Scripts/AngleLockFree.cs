using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleLockFree : MonoBehaviour
{

    public GameObject hintobject;
    private Vector3 startpos;
    private Quaternion startrot;


    private void Start()
    {
        startpos = hintobject.transform.position;
        startrot = hintobject.transform.rotation;
    }

    public void Lock()
    {
        if (hintobject.GetComponent<FixedJoint>() == null)
        {
            hintobject.transform.position = startpos;
            hintobject.transform.rotation = startrot;
            hintobject.AddComponent<FixedJoint>();
        }
        
    }

    public void Freee()
    {
        Destroy(hintobject.GetComponent<FixedJoint>());
    }


}
