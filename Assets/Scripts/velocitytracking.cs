using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocitytracking : MonoBehaviour
{
    public GameObject head, card;
    private Rigidbody speedo;
    private bool once0, once1;
    private AudioSource source0;
    public AudioClip clipaki;

    private void Start()
    {
        speedo = head.GetComponent<Rigidbody>();
        once0 = true;
        once1 = true;
        source0 = head.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(speedo.velocity.magnitude > 0.1 & once0)
        {
            once0 = false;
            source0.Play();
            card.GetComponent<Rigidbody>().useGravity = true;
            card.GetComponent<BoxCollider>().enabled = true;
            //card.SetActive(true);
        }

        if(!once0 & once1)
        {
            once1 = false;
            StartCoroutine(Waiting(0.5f));
            head.GetComponent<HeadFocus>().HeadFell();
            
        }
    }

    private IEnumerator Waiting(float x)
    {
        yield return new WaitForSeconds(x);
        source0.Stop();
        source0.clip = clipaki;
        source0.Play();
        yield return null;
    }
}
