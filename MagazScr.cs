using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazScr : MonoBehaviour
{
    public GameObject TheGame;
    public GameObject StartGame;
    public GameObject Lose;
    public GameObject MagazinGame;

    void Start()
    {

    }
    void Update()
    {

    }
    public void OnMouseDownAsButtonMagazin()
    {
        TheGame.SetActive(false);
        StartGame.SetActive(false);
        Lose.SetActive(false);
        MagazinGame.SetActive(true);
    }
}
