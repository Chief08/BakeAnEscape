using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCheck : MonoBehaviour
{
    public GameObject obj;
    private Quaternion angle;
    public bool doStuff;

    // Start is called before the first frame update
    void Start()
    {
        doStuff = false;
    }

    // Update is called once per frame
    void Update()
    {
        angle = obj.transform.rotation;
        if (angle.x > 0.68f) 
        {
            doStuff = true;
        }
        else
        {
            doStuff = false;
        }
    }
}
