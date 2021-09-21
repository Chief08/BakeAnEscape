using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Dswitch;
    private Quaternion angle;
  
    

    // Update is called once per frame

    public void OnClick() 
    {
        angle = Dswitch.transform.rotation;
        angle.z = -angle.z;
        Dswitch.transform.rotation = angle;
        gameObject.GetComponent<AudioSource>().Play();
    }

   
}
