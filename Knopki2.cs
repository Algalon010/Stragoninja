using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knopki2 : MonoBehaviour
{
    public GameObject TheGame;
    public GameObject StartGame;
    public GameObject Lose;
    public GameObject ChoseSwordGame;

    public void OnMouseDownAsButton()
    {
        SceneManager.LoadScene(“New Scene2”);
        TheGame.SetActive(false);
        ChoseSwordGame.SetActive(false);
        StartGame.SetActive(false);
        Lose.SetActive(false);
        Debug.Log(“Выполнен рестарт”);
    }
}
