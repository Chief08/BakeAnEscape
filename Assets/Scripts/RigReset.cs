using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigReset : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.magnitude > 20)
        {
            gameObject.transform.position = new Vector3(0, 0.5f, 0);
        }
    }
}
