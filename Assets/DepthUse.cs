using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthUse : MonoBehaviour
{
    public Camera focus;
    // Start is called before the first frame update
    void Start()
    {

        focus.depthTextureMode = DepthTextureMode.Depth;
        Debug.Log(focus.depthTextureMode + focus.name);
    }

    // Update is called once per frame
    void Update()
    {
        WaitLord();
    }


    private  IEnumerator WaitLord()
    {
        yield return new WaitForSeconds(0.1f);
    }
}

