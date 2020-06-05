using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Info;
    public GameObject TargetImg;
    public Sprite Spr;


    private void OnMouseDown()
    {
        Info.SetActive(true);
        TargetImg.SetActive(true);

        Info.GetComponent<Text>().text = "Soldier";
        TargetImg.GetComponent<Image>().sprite = Spr;
        Target1.SetActive(true);
    }
}