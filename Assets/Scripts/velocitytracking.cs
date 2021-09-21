using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocitytracking : MonoBehaviour
{
    public GameObject head, card;
    private Rigidbody speedo;
    private bool once0;
    private AudioSource source0;
    public AudioClip clipaki;

    private void Start()
    {
        speedo = head.GetComponent<Rigidbody>();
        once0 = true;
        source0 = head.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(speedo.velocity.magnitude > 0.1 & once0)
        {
            once0 = false;
            source0.Play();
            card.SetActive(true);
        }

        if(!once0)
        {
            StartCoroutine(Waiting(1));
            
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
