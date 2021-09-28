using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusStaff : MonoBehaviour
{
    private int FocusedLayer;
    private GameObject currentlyFocused;
    private int previousLayer;


    void Start()
    {
        currentlyFocused = gameObject;
        previousLayer = 8;
        FocusedLayer = 12;
    }
    

    public void SetFocused()
    {
        previousLayer = currentlyFocused.layer;
        SetLayerRecursively(currentlyFocused, FocusedLayer);
    }


    public void SetUnfocused()
    {
        SetLayerRecursively(currentlyFocused, previousLayer);
    }

    private void SetLayerRecursively(GameObject obj, int newLayer)
    {
        if (null == obj)
        {
            return;
        }

        obj.layer = newLayer;

        foreach (Transform child in obj.transform)
        {
            if (null == child)
            {
                continue;
            }
            SetLayerRecursively(child.gameObject, newLayer);
        }
    }


}
