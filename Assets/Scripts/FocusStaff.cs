using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusStaff : MonoBehaviour
{
    private string FocusedLayer = "Focused";
    private GameObject currentlyFocused;
    private int previousLayer;


    void Start()
    {
        currentlyFocused = gameObject;
    }
    

    public void SetFocused(GameObject obj)
    {
        previousLayer = currentlyFocused.layer;
        currentlyFocused.layer = LayerMask.NameToLayer(FocusedLayer);
    }


    public void SetUnfocused()
    {
        currentlyFocused.layer = previousLayer;
    }

}
