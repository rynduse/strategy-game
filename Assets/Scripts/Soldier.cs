using UnityEngine;
using System.Collections;

public class Soldier : MonoBehaviour
{

    [SerializeField]
    private GameObject finalObject;

    public void SoldierInstantiate()
    {
        Instantiate(finalObject, this.transform.position, Quaternion.identity);
    }
}
