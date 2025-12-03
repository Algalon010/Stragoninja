using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sworder2 : MonoBehaviour
{
    public GameObject Sword2;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mousex = (Input.mousePosition.x);
            float mousey = (Input.mousePosition.y);
            Vector3 mouseposition = Camera.main.ScreenToWorldPoint(new Vector3(mousex, mousey, 5));
            Sword2.transform.position = mouseposition;
        }
    }
}
