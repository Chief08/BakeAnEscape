using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablelimits : MonoBehaviour
{
    public GameObject limit0, limit1, knife;
    private float time0, time1;


    private void Start()
    {
        time0 = -100;
        time1 = -100;
    }

    // Update is called once per frame
    void Update()
    {
        float temptime;
        temptime = CheckDistance(limit0, time0);
        if (Mathf.Abs(temptime - Time.time) > 2) 
        {
            limit0.SetActive(false);
        }
        time0 = temptime;

        temptime = CheckDistance(limit1, time1);
        if (Mathf.Abs(temptime - Time.time) > 2)
        {
            limit1.SetActive(false);
        }
        time1 = temptime;
    }

    float CheckDistance(GameObject x, float timer) 
    {

        if (Vector3.Distance(x.transform.position, knife.transform.position) < 0.3 ) 
        {
            x.SetActive(true);
            return Time.time;
        }
        return timer;
    }
}
