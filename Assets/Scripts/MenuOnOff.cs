using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuOnOff : MonoBehaviour
{
    public XRNode inputSource;
    public GameObject UIMenu;

    private InputDevice targetDevice;
    private bool previousstate;



    void Start()
    {
        targetDevice = InputDevices.GetDeviceAtXRNode(inputSource);
        previousstate = false;
    }


    private void Update()
    {
        Menu();
    }

  

    private void Menu()
    {

        if (targetDevice.TryGetFeatureValue(CommonUsages.menuButton, out bool OnOff))
        {
            Debug.Log(OnOff);
            if (previousstate != OnOff & OnOff)
            {
                UIMenu.SetActive(!UIMenu.activeSelf);
            }
            previousstate = OnOff;
        }
    }

}
