using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableScreen : MonoBehaviour
{

    public GameObject Dswitch;
    private Quaternion angle;
    private Quaternion anglex;

    private void Start()
    {
        anglex.Set(0,0,1,0);
    }


    public void OnClick()
    {
        angle = Dswitch.transform.rotation;
        Dswitch.transform.rotation = angle*anglex;
    }
}
