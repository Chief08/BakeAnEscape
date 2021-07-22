using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchy : MonoBehaviour
{
    public GameObject lightlamp;

    public void OnClick() 
    {
        if (lightlamp.activeSelf) 
        {
            lightlamp.SetActive(false);
        }
        else
        {
            lightlamp.SetActive(true);
        }
    }
}
