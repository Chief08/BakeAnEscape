using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockMotion : MonoBehaviour
{
    public GameObject drawer, card;
    
    private ConfigurableJoint jointt;

    // Start is called before the first frame update
    void Start()
    {
        jointt = GetComponent<ConfigurableJoint>();
        jointt.xMotion = ConfigurableJointMotion.Locked;
    }

    private void Freee()
    {
        if(Vector3.Distance(card.transform.position , new Vector3(1.65499997f, 0.727999985f, 0.620000005f)) < 0.2 & card.activeSelf)
        {
            jointt.xMotion = ConfigurableJointMotion.Limited;
        }
    } 

    // Update is called once per frame
    void Update()
    {
        Freee();
    }
}
