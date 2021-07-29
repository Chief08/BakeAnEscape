using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SoundTrigger : MonoBehaviour
{
    public AudioClip triggerSound;
    public GameObject handCord;
    public GameObject hand1Cord;
    public GameObject radioCord;
    private bool on_off;
    private float triggerValue0;
    private float triggerValue1; 
    public XRNode inputSource0;
    private InputDevice targetDevice0;
    public XRNode inputSource1;
    private InputDevice targetDevice1;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

        targetDevice0 = InputDevices.GetDeviceAtXRNode(inputSource0);
        targetDevice1 = InputDevices.GetDeviceAtXRNode(inputSource1);
        audioSource = radioCord.GetComponent<AudioSource>();
        on_off = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void  Music() 
    {
        if (targetDevice0.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            triggerValue0 = triggerValue;
        }
        else
        {

            triggerValue0 = 0;
        }
        if (targetDevice1.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue3))
        {
            triggerValue1 = triggerValue3;
        }
        else
        {

            triggerValue1 = 0;
        }
        if (Vector3.Distance(handCord.transform.position, radioCord.transform.position) < 0.05f & triggerValue0 > 0.5)
        {
            on_off = !on_off;
            if (on_off)
            {
                audioSource.PlayOneShot(triggerSound, 0.7f);
            }
            else
            {
                audioSource.Stop();
            }
        }
        if (Vector3.Distance(hand1Cord.transform.position, radioCord.transform.position) < 0.1f & triggerValue1 > 0.5)
        {
            on_off = !on_off;
            if (on_off)
            {
                Debug.Log("why no sound");
                audioSource.PlayOneShot(triggerSound);

            }
            else
            {
                audioSource.Stop();
            }
        }
    }

}
