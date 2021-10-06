using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DrawerUnlock : MonoBehaviour
{

    public GameObject Dswitch, console0, console1, screeno, drawer, card;
    private Quaternion angle;
    private Quaternion anglex;
    private bool once0, once1;




    private void Start()
    {
        once0 = true;
        once1 = false;
        anglex.Set(0,0,1,0);

    }

    private void Update()
    {
        if (console0.GetComponent<LightsCheck>().Ready() & console1.GetComponent<LightsCheck>().Ready() & once0)
        {
            console0.GetComponent<AudioSource>().Play();
            once0 = false;
            once1 = true;
        }
    }


    public void OnClick()
    {
        
            if (once1)
            {
                once1 = false;
                drawer.GetComponent<AngleLockFree>().Freee();
                drawer.GetComponent<AudioSource>().Play();
                screeno.GetComponent<ScreenSwaps>().UnlockDrawer();
                card.GetComponent<AngleLockFree>().Freee();
                card.GetComponent<XRGrabInteractable>().enabled = true;
            }

            gameObject.GetComponent<AudioSource>().Play();

            angle = Dswitch.transform.rotation;
            Dswitch.transform.rotation = angle * anglex;
        
    }
}
