using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable_screen : MonoBehaviour
{

    public GameObject Dswitch;
    

    public void OnClick()
    {
        Dswitch.transform.Rotate(0, 0, 90, Space.Self);
    }
}