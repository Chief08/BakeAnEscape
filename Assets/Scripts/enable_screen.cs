using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable_screen : MonoBehaviour
{

    public GameObject Dswitch, screen, cardholder;
    private bool gas;

    private void Start()
    {
        gas = true;
    }

    public void OnClick()
    {
        Dswitch.transform.Rotate(0, 0, 90, Space.Self);
        if(gas)
        {
            cardholder.GetComponent<Login>().enabled = true;
            screen.GetComponent<ScreenSwaps>().ScreenLog();
            gas = !gas;
        }
        else
        {
            cardholder.GetComponent<Login>().enabled = false;
            screen.GetComponent<ScreenSwaps>().GasOn();
            gas = !gas;
        }
    }
}