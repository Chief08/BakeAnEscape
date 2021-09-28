using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFocus : MonoBehaviour
{
    public GameObject UV,Headhint,Card,CardHint,Drawer;
    private GameObject head;
    private bool once, seen;


    void Start()
    {
        head = gameObject;
        once = true;
        seen = UV.GetComponents<Visible>()[0].hint;
    }

    // Update is called once per frame
    void Update()
    {
        if(seen & once)
        {
            once = false;
            head.GetComponent<FocusStaff>().SetFocused();
            Headhint.GetComponent<FocusStaff>().SetFocused();
        }
    }

    public void HeadFell()
    {

        head.GetComponent<FocusStaff>().SetUnfocused();
        Headhint.GetComponent<FocusStaff>().SetUnfocused();
        Card.GetComponent<FocusStaff>().SetFocused();
        CardHint.GetComponent<FocusStaff>().SetFocused();
        Drawer.GetComponent<FocusStaff>().SetFocused();
    }
}
