using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsCheck : MonoBehaviour
{
    public List<bool> list0;

    private void Start()
    {
        list0 = new List<bool> { };
        for (int i = 0; i < 10; i++)
        {
            int x = Random.Range(0, 2);
            if (x == 0)
            {
                list0.Add(false);
            }
            else
            {
                list0.Add(true);
            }
        }
    }

    public bool Ready()
    {
        GameObject lighto;
        Light lt;
        int y = 0;
        for(int i=0; i<10; i++)
        {
            lighto = gameObject.transform.GetChild(i).gameObject;
            lt = lighto.GetComponent<Light>();
            if (Colorcheck(lt,i))
            {
                y++;
            }
        }
        Debug.Log(y);
        return (y==10);
    }


    public bool Colorcheck(Light lt, int i)
    {
        if ((lt.color == Color.green) == list0[i])
            return true;
        else
            return false;
    }
}
