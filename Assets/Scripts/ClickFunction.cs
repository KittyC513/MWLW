using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFunction : MonoBehaviour
{
    public GameObject laptop;
    public GameObject laptopUI;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if mouse-left button is pressed, it will raycast a position from mouse to detect if the mouse is clicking an object
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;

                if (bc != null)
                {
                    laptopUI.SetActive(true);
                }

            }
        }

    }
}
        



