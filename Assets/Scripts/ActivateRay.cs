using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateRay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hand, ray;


    // Update is called once per frame
    void Update()
    {
        if (hand.transform.position.y<0.5)
        {
            ray.GetComponent<XRBaseInteractor>().interactionLayerMask = LayerMask.GetMask("Grab");
        }
        
        if(hand.transform.position.y > 0.5 & !ray.GetComponent<XRBaseControllerInteractor>().isSelectActive)
        {
            ray.GetComponent<XRBaseInteractor>().interactionLayerMask = LayerMask.GetMask("Nothing");
        }
    }
}
