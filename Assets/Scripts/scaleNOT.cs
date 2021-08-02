using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleNOT : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

        door.transform.localScale = new Vector3(1, 0.7f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        door.transform.localScale = new Vector3(1, 0.7f, 0.7f);
    }
}
