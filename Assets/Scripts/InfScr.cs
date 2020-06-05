using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfScr : MonoBehaviour
{
    public GameObject prefabButton;
    public GameObject prefabButton2;
    public RectTransform ParentPanel;

    public RectTransform ParentPanel2;
    public GameObject prefabButton3;
    public GameObject prefabButton4;
    private void Start()
    {
        for (int i = -20; i < 3000; i += 20)
        {
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            goButton.transform.SetParent(ParentPanel, false);
            goButton.transform.localScale = new Vector3(1, 1, 1);
            goButton.transform.position = new Vector3(0, i, 0);

            GameObject goButton2 = (GameObject)Instantiate(prefabButton2);
            goButton2.transform.SetParent(ParentPanel, false);
            goButton2.transform.localScale = new Vector3(1, 1, 1);
            goButton2.transform.position = new Vector3(0, i, 0);



            GameObject goButton3 = (GameObject)Instantiate(prefabButton3);
            goButton3.transform.SetParent(ParentPanel2, false);
            goButton3.transform.localScale = new Vector3(1, 1, 1);
            goButton3.transform.position = new Vector3(0, i, 0);

            GameObject goButton4 = (GameObject)Instantiate(prefabButton4);
            goButton4.transform.SetParent(ParentPanel2, false);
            goButton4.transform.localScale = new Vector3(1, 1, 1);
            goButton4.transform.position = new Vector3(0, i, 0);
        }
    }
}
