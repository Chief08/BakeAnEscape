using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    public GameObject screen, limit0, limit1;

    void Update()
    {
        if(limit0.activeSelf & limit1.activeSelf)
        {
            screen.GetComponent<ScreenSwaps>().ScreenRiddle();
        }
    }
}
