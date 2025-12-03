using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sworder : MonoBehaviour
{
    public GameObject Sword;
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
            Sword.transform.position = mouseposition;
        }
    }
}
