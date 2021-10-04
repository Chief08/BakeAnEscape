using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    public GameObject totoro, radio, uvlight, library, hiddendoor, volume, VrRig;
    private Vector2 xlimits, ylimits, zlimits;
    private ConfigurableJoint jointt;
    public float speed,timer;
    private bool moved,load;


    // Start is called before the first frame update
    void Start()
    {
        xlimits = new Vector2(-0.5f, -2.3f);
        zlimits = new Vector2(2.55f,2f);
        jointt = library.GetComponent<ConfigurableJoint>();
        moved = true;
        load = false;
    }

    // Update is called once per frame
    void Update()
    {
        ylimits = new Vector2(1.37f, 0.75f) ;
        bool a = CheckPos(xlimits, ylimits, zlimits, radio);
        
        ylimits = new Vector2(2.16f, 1.56f);

        bool b = CheckPos(xlimits, ylimits, zlimits, totoro);
       

        ylimits = new Vector2(3f, 2.25f);

        bool c = CheckPos(xlimits, ylimits, zlimits, uvlight);
        

        if (a&b&c&moved)
        {
            moved = false;
            hiddendoor.SetActive(true);
            StartCoroutine(Movelibrary(speed));
        }

        if (load)
        {
            VrRig.GetComponent<MyLoadScene>().Loadlevel("RoomUno");
        }
    }

    private bool CheckPos(Vector2 xlimits, Vector2 ylimits, Vector2 zlimits , GameObject objecto)
    {
        if(objecto.transform.position.x<xlimits.x & objecto.transform.position.x > xlimits.y) 
        {
            if(objecto.transform.position.y < ylimits.x & objecto.transform.position.y > ylimits.y)
            {
                if (objecto.transform.position.z < zlimits.x & objecto.transform.position.z > zlimits.y)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private IEnumerator Movelibrary(float speed)
    {
        volume.SetActive(false);
        Vector3 targetposition = library.transform.position + new Vector3(2, 0, 0);
        yield return new WaitForSeconds(0.5f);
        jointt.zMotion = ConfigurableJointMotion.Free;
        library.GetComponent<AudioSource>().Play();
        timer = Time.time;
        while (timer + 3 > Time.time)
        {
            library.transform.position = Vector3.Lerp(library.transform.position, targetposition, Time.deltaTime * speed);
            yield return new WaitForEndOfFrame();
        }
        jointt.zMotion = ConfigurableJointMotion.Locked;
        yield return new WaitForSeconds(1f);
        load = true;
    }

}
