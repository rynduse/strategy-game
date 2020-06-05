using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barrack : MonoBehaviour
{
    public GameObject Info;
    public GameObject BuildImg;
    public GameObject Unit;
    public GameObject Soldier;
    public Sprite Spr;
    public GameObject Target1;
    public GameObject Barrack1;
    public GameObject House1;
    public GameObject PowerPlant1;
    public GameObject Temple1;
    public GameObject Error;
    [SerializeField]
    private GameObject finalObject;

    public Vector2 mousePos;
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
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
        GameObject.Find("Barrack (1)").transform.position = finalObject.transform.position;
        Error.SetActive(true);
        Barrack1.SetActive(false);
        House1.SetActive(false);
        PowerPlant1.SetActive(false);
        Temple1.SetActive(false);
        Info.SetActive(true);
        BuildImg.SetActive(true);
        Unit.SetActive(true);
        Soldier.SetActive(true);
        Target1.SetActive(false);
        Info.GetComponent<Text>().text = "Barrack";
        BuildImg.GetComponent<Image>().sprite = Spr;
    }
}
