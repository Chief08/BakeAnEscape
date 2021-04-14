using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerPrefabs;
    public GameObject handModelPrefab;

    private InputDevice targetDevice;
    private GameObject spawnedHandModel;
    private Animator handAnimator;


    // Start is called before the first frame update
    void Start()
    {

        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);
        Debug.Log(devices.Count);

        foreach (var item in devices) {
            Debug.Log(item.name + item.characteristics);
        }

        if(devices.Count > 0) {
            targetDevice = devices[0];
            spawnedHandModel = Instantiate(handModelPrefab, transform);
            handAnimator = spawnedHandModel.GetComponent<Animator>();
        }

    }

    void UpdateAniamtor() {

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue)) {
            handAnimator.SetFloat("trigger", triggerValue);
        }
        else {
            handAnimator.SetFloat("trigger", 0);
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("grip", gripValue);
        }
        else
        {
            handAnimator.SetFloat("grip", 0);
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        spawnedHandModel.SetActive(true);
        //UpdateAniamtor();
    }
}
