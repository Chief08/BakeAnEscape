using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateRay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hand, ray;
    private GradientColorKey[] colorKey;
    private GradientAlphaKey[] alphaKey;


    // Update is called once per frame
    void Update()
    {
        if (hand.transform.position.y<0.5)
        {
            // Populate the color keys at the relative time 0 and 1 (0 and 100%)
            colorKey = new GradientColorKey[2];
            colorKey[0].color = Color.white;
            colorKey[0].time = 0.0f;
            colorKey[1].color = Color.white;
            colorKey[1].time = 1.0f;

            // Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
            alphaKey = new GradientAlphaKey[2];
            alphaKey[0].alpha = 0.1f;
            alphaKey[0].time = 0.0f;
            alphaKey[1].alpha = 0.1f;
            alphaKey[1].time = 1.0f;
            ray.GetComponent<XRBaseInteractor>().interactionLayerMask = LayerMask.GetMask("Grab");
            ray.GetComponent<XRInteractorLineVisual>().invalidColorGradient.SetKeys(colorKey, alphaKey);
        }
        
        if(hand.transform.position.y > 0.5 & !ray.GetComponent<XRBaseControllerInteractor>().isSelectActive)
        {
            ray.GetComponent<XRBaseInteractor>().interactionLayerMask = LayerMask.GetMask("Nothing");

            // Populate the color keys at the relative time 0 and 1 (0 and 100%)
            colorKey = new GradientColorKey[2];
            colorKey[0].color = Color.white;
            colorKey[0].time = 0.0f;
            colorKey[1].color = Color.white;
            colorKey[1].time = 1.0f;

            // Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
            alphaKey = new GradientAlphaKey[2];
            alphaKey[0].alpha = 0.0f;
            alphaKey[0].time = 0.0f;
            alphaKey[1].alpha = 0.0f;
            alphaKey[1].time = 1.0f;

            ray.GetComponent<XRInteractorLineVisual>().invalidColorGradient.SetKeys(colorKey, alphaKey);
        }
    }
}
