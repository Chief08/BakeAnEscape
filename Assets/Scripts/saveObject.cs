using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveObject : MonoBehaviour
{
    public GameObject objecto;
    
    // Update is called once per frame
    void Update()
    {
        if(objecto.transform.position.y<-1)
        {
            Debug.Log("d");
            Vector3 pos = objecto.transform.position;
            pos.y = 0.01f;
            objecto.transform.position = pos;
        }
    }
}
