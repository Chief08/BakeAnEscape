using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenHints : MonoBehaviour
{

    public GameObject UV, UvHint ;
    private bool hint0,hint1;

   

    private void Update()
    {
        hint0 = UV.GetComponents<Visible>()[0].hint;
        hint1 = UV.GetComponents<Visible>()[1].hint;
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
