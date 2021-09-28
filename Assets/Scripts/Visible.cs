using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visible : MonoBehaviour
{
    public GameObject uvlight;
    public GameObject message;
    public GameObject lightlamp;
    public bool hint;


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(message.transform.position, uvlight.transform.position) < 1 & uvlight.activeSelf & !lightlamp.activeSelf) 
        {
            message.SetActive(true);
            hint = true;
        }
        else
        {
            message.SetActive(false);
        }
    }
}
