using UnityEngine;
using System.Collections;

public class PFTarget : MonoBehaviour
{
    private Vector2 mousePos;

    public GameObject Target1;

    [SerializeField]
    private LayerMask allTilesLayer;

    // Update is called once per frame

    private void Update()
    {
        AstarPath.active.Scan();
        if (Input.GetMouseButtonDown(1))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
            RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, allTilesLayer);
        }
    }
}
