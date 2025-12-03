using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sworder3 : MonoBehaviour
{
    public GameObject Sword3;
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
            Sword3.transform.position = mouseposition;
        }
    }
}
