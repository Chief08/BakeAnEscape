using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysRotate : MonoBehaviour
{
  
    void Update()
    {
        gameObject.transform.Rotate(0, 360 * Time.deltaTime, 0 ); //rotates 50 degrees per second around z axis
    }
}
