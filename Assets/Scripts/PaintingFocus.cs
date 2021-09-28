using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingFocus : MonoBehaviour
{
    public GameObject card, cardhint, drawer, knife, totoro, UV, Radio, finalhint;
    private GameObject painting;

    // Start is called before the first frame update
    void Start()
    {
        painting = gameObject;
    }

    public void DrawerUnlocked()
    {
        card.GetComponent<FocusStaff>().SetUnfocused();
        cardhint.GetComponent<FocusStaff>().SetUnfocused();
        drawer.GetComponent<FocusStaff>().SetUnfocused();
        painting.GetComponent<FocusStaff>().SetFocused();
        knife.GetComponent<FocusStaff>().SetFocused();
    }

    public void PaintingSliced()
    {

        knife.GetComponent<FocusStaff>().SetUnfocused();
        painting.GetComponent<FocusStaff>().SetUnfocused();
        totoro.GetComponent<FocusStaff>().SetFocused();
        UV.GetComponent<FocusStaff>().SetFocused();
        Radio.GetComponent<FocusStaff>().SetFocused();
        finalhint.GetComponent<FocusStaff>().SetFocused();
    }
}
