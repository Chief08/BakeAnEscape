using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    public GameObject screen, limit0, limit1, door;

    void Update()
    {
        if(limit0.activeSelf & limit1.activeSelf)
        {
            screen.GetComponent<ScreenSwaps>().ScreenRiddle();
            door.GetComponent<AngleLockFree>().Freee();
        }
    }
}
