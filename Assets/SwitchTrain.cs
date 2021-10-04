using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrain : MonoBehaviour
{
   public void Vertically()
    {
        gameObject.transform.Rotate(180, 0, 0, Space.Self);
    }

    public void Horizontally()
    {
        gameObject.transform.Rotate(0, 0, 90, Space.Self);
    }
}
