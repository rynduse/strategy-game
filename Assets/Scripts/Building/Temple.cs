using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temple : MonoBehaviour
{
    public GameObject Info;
    public GameObject BuildImg;
    public Sprite Spr;
    public GameObject Unit;
    public GameObject Soldier;
    public GameObject Target1;

    public GameObject Barrack1;
    public GameObject House1;
    public GameObject PowerPlant1;
    public GameObject Temple1;
    public GameObject Error;
    private float timeLeft = 5;

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Error.SetActive(false);
            timeLeft += 7;
        }
    }
    private void OnMouseDown()
    {
        Error.SetActive(true);
        Barrack1.SetActive(false);
        House1.SetActive(false);
        PowerPlant1.SetActive(false);
        Temple1.SetActive(false);
        Info.SetActive(true);
        BuildImg.SetActive(true);
        Unit.SetActive(false);
        Soldier.SetActive(false);
        Target1.SetActive(false);

        Info.GetComponent<Text>().text = "Temple";
        BuildImg.GetComponent<Image>().sprite = Spr;
    }
}
