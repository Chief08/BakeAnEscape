using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrandFinale : MonoBehaviour
{
    public GameObject screeno;
    private bool onlyonce;
    // Start is called before the first frame update
    void Start()
    {
        onlyonce = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<XRBaseInteractable>().isSelected & onlyonce)
        {
            onlyonce = false;
            screeno.GetComponent<ScreenSwaps>().UnlockDrawer();
            StartCoroutine(FinalScene());
        }
    }

    private IEnumerator FinalScene()
    {
        yield return new WaitForSeconds(1);
        // final animation
        // load credit scene
        Debug.Log("end");

    }
}
