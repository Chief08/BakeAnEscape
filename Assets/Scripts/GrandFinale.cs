using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class GrandFinale : MonoBehaviour
{
    public GameObject screeno, siren, Vrrig, siren0, lighto, spotlight0, spotlights1;
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
        screeno.GetComponent<ScreenSwaps>().LockEverything();
        //siren
        Debug.Log("end");
        siren0.SetActive(true);
        siren.SetActive(true);
        siren.GetComponent<AudioSource>().Play();
        lighto.SetActive(false);
        spotlight0.SetActive(false);
        spotlights1.SetActive(false);

        yield return new WaitForSeconds(10);
        Vrrig.GetComponent<MyLoadScene>().Loadlevel("Ending");

    }
}
