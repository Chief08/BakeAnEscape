using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    public XRNode inputSource;
    public GameObject handModelPrefab;

    private InputDevice targetDevice;
    private GameObject spawnedHandModel;
    private Animator handAnimator;


    // Start is called before the first frame update
    void Start()
    {

        targetDevice = InputDevices.GetDeviceAtXRNode(inputSource);
        Debug.Log(targetDevice.name);
        handAnimator = handModelPrefab.GetComponent<Animator>();

    }

    void UpdateAnimator() {

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue)) {
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else {
            handAnimator.SetFloat("Trigger", 0);
        }


        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", gripValue);

        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        targetDevice = InputDevices.GetDeviceAtXRNode(inputSource);
        UpdateAnimator();
    }
}
