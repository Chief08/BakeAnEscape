using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DrawerUnlock : MonoBehaviour
{

    public GameObject Dswitch, console0, console1, screeno, drawer, card;
    private Quaternion angle;
    private Quaternion anglex;




    private void Start()
    {
        anglex.Set(0,0,1,0);
    }


    public void OnClick()
    {
        {
            if (console0.GetComponent<LightsCheck>().Ready() & console1.GetComponent<LightsCheck>().Ready())
            {
                drawer.GetComponent<AngleLockFree>().Freee();
                screeno.GetComponent<ScreenSwaps>().UnlockDrawer();
                card.GetComponent<AngleLockFree>().Freee();
                card.GetComponent<XRGrabInteractable>().enabled = true;
            }

            angle = Dswitch.transform.rotation;
            Dswitch.transform.rotation = angle * anglex;
        }
    }
}
