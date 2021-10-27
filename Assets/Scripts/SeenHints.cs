using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenHints : MonoBehaviour
{
    public GameObject head, bat, bathint;
    public GameObject UV, UvHint ;
    private bool hint0,hint1,once;


    private void Start()
    {
        hint0 = false;
        hint1 = false;
        once = true;
    }


    private void Update()
    {
        hint0 = UV.GetComponents<Visible>()[0].hint | hint0;
        hint1 = UV.GetComponents<Visible>()[1].hint | hint1;

        if (hint1 & once)
        {
            once = false;
            bat.GetComponent<FocusStaff>().SetFocused();
            bathint.GetComponent<FocusStaff>().SetFocused();
            head.GetComponent<FocusStaff>().SetFocused();
        }

        if(hint0 & hint1)
        {
            UnfocusUV();
        }
    }

    private void UnfocusUV()
    {
        UV.GetComponent<FocusStaff>().SetUnfocused();
        UvHint.GetComponent<FocusStaff>().SetUnfocused();
    }
}
