using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public GameObject Barrack;
    public GameObject PowerPlant;
    public GameObject House;
    public GameObject Temple;

    public void BuildBarrack()
    {
        Barrack.SetActive(true);
    }

    public void BuildPowerPlant()
    {
        PowerPlant.SetActive(true);
    }

    public void BuildHouse()
    {
        House.SetActive(true);
    }

    public void BuildTemple()
    {
        Temple.SetActive(true);
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Barrack.SetActive(false);
            PowerPlant.SetActive(false);
            House.SetActive(false);
            Temple.SetActive(false);
        }
    }
}
