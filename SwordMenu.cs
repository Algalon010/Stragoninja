using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMenu : MonoBehaviour
{
    public GameObject Lose;
    public GameObject ChoseSwordGame;

    void Start()
    {
        
    }
    public void OnMouseDownAsButtonSwordMenu()
    {
        ChoseSwordGame.SetActive(true);
        Lose.SetActive(false);
    }
    void Update()
    {
    }
}
