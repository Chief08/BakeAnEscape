using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockMotion : MonoBehaviour
{
    public GameObject drawer, card, painting;
    
    private ConfigurableJoint jointt;
    private bool once;

    // Start is called before the first frame update
    void Start()
    {
        once = true;
        jointt = GetComponent<ConfigurableJoint>();
        jointt.xMotion = ConfigurableJointMotion.Locked;
    }

    private void Freee()
    {
        if(Vector3.Distance(card.transform.position , new Vector3(1.65499997f, 0.727999985f, 0.620000005f)) < 0.2 & card.activeSelf & once)
        {
            once = false;
            gameObject.GetComponent<AudioSource>().Play();
            jointt.xMotion = ConfigurableJointMotion.Limited;
            painting.GetComponent<PaintingFocus>().DrawerUnlocked();
        }
    } 

    // Update is called once per frame
    void Update()
    {
        Freee();
    }
}
