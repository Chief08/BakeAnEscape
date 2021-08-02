using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenlight : MonoBehaviour
{
    public GameObject lever;
    public GameObject leverlight;
    private Quaternion angle;
    private Light lt;

    private void Start()
    {
        lt = leverlight.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        angle = lever.transform.rotation;
        if (angle.x < -0.3f)
        {
            lt.color = Color.green;
        }
        else
        {
            lt.color = Color.red;
        }
    }
}