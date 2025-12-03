using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject MainCamera;
    public Text scoreTextLose;
    public Text scoreTextLoseOne;
    public Text totalTextLose;
    public Text totalTextLoseTwo;
    public Text scoreText;
    public Text totalText;
    public int score;
    public int record;
    static int recordTotal;
    public int recordTotalMag;
    public GameObject Price1Text;
    public GameObject Buy1;
    public GameObject Price2Text;
    public GameObject Buy2;
    public GameObject Price3Text;
    public GameObject Buy3;
    public int Buy1FonYes;
    public int Buy2FonYes;
    public int Buy3FonYes;
    public GameObject Sword;
    public GameObject Sword1;
    public GameObject Sword2;
    public GameObject Sword3;


    public void Start()
    {
       // MainCamera.GetComponent<Game>().enabled = true;
        totalTextLoseTwo.text = totalTextLose.text;
    }
    public void OnClick()
    {
        score++;
        recordTotal++;
        scoreText.text = “” + score;
        scoreTextLoseOne.text = scoreText.text;
        totalText.text = scoreTextLoseOne.text;
        totalText.text = “” + recordTotal.ToString();
        totalTextLose.text = totalText.text;
    }
    public void Update()
    {
        if (score > record)
        {
            PlayerPrefs.SetInt(“savedScore”, score);
            PlayerPrefs.Save();
        }
        record = PlayerPrefs.GetInt(“savedScore”);
        scoreTextLose.text = “” + record.ToString();

        if (recordTotal > 0)
        {
            PlayerPrefs.SetInt(“savedTotal”, recordTotal);
            PlayerPrefs.Save();
        }
        recordTotal = PlayerPrefs.GetInt(“savedTotal”);
        totalText.text = “” + recordTotal.ToString();

        if (Buy1FonYes > 0)
        {
            //Buy1FonYes = 0; 
            PlayerPrefs.SetInt(“savedBuy1”, Buy1FonYes);
            PlayerPrefs.Save();
            Price1Text.SetActive(false);
            Buy1.SetActive(false);
        }
        Buy1FonYes = PlayerPrefs.GetInt(“savedBuy1”, Buy1FonYes);
        PlayerPrefs.Save();

        if (Buy2FonYes > 0)
        {
            //Buy2FonYes = 0;
            PlayerPrefs.SetInt(“savedBuy2”, Buy2FonYes);
            PlayerPrefs.Save();
            Price2Text.SetActive(false);
            Buy2.SetActive(false);
        }
        Buy2FonYes = PlayerPrefs.GetInt(“savedBuy2”, Buy2FonYes);
        PlayerPrefs.Save();

        if (Buy3FonYes > 0)
        {
            //Buy2FonYes = 0;
            PlayerPrefs.SetInt(“savedBuy3”, Buy3FonYes);
            PlayerPrefs.Save();
            Price3Text.SetActive(false);
            Buy3.SetActive(false);
        }
        Buy3FonYes = PlayerPrefs.GetInt(“savedBuy3”, Buy3FonYes);
        PlayerPrefs.Save();
    }




    public void OnMouseDownAsButtonStartBuy1()
    {
        recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
        if (recordTotal > 200)
        {
            Destroy(MainCamera.GetComponent<Game>());
            MainCamera.GetComponent<Game>().enabled = false;
            recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
            recordTotal -= 200;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt(“savedTotal”, recordTotal);
            recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
            PlayerPrefs.Save();
            totalTextLoseTwo.text = “” + recordTotal.ToString();
            PlayerPrefs.SetInt(“savedBuy”, Buy1FonYes++);
            PlayerPrefs.Save();
            SceneManager.LoadScene(“New Scene1”);
        }
    }
    public void OnMouseDownAsButtonStartBuy2()
    {
        recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
        if (recordTotal > 600)
        {
            Destroy(MainCamera.GetComponent<Game>());
            MainCamera.GetComponent<Game>().enabled = false;
            recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
            recordTotal -= 600;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt(“savedTotal”, recordTotal);
            recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
            PlayerPrefs.Save();
            totalTextLoseTwo.text = “” + recordTotal.ToString();
            PlayerPrefs.SetInt(“savedBuy”, Buy2FonYes++);
            PlayerPrefs.Save();
            SceneManager.LoadScene(“New Scene2”);
        }
    }
    public void OnMouseDownAsButtonStartBuy3()
    {
        recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
        if (recordTotal > 1000)
        {
            Destroy(MainCamera.GetComponent<Game>());
            MainCamera.GetComponent<Game>().enabled = false;
            recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
            recordTotal -= 1000;
            PlayerPrefs.Save();
            PlayerPrefs.SetInt(“savedTotal”, recordTotal);
            recordTotal = PlayerPrefs.GetInt(“savedTotal”, recordTotal);
            PlayerPrefs.Save();
            totalTextLoseTwo.text = “” + recordTotal.ToString();
            PlayerPrefs.SetInt(“savedBuy”, Buy3FonYes++);
            PlayerPrefs.Save();
            SceneManager.LoadScene(“New Scene3”);
        }
    }
    public void OnMouseDownAsButtonStartSword()
    {
        SceneManager.LoadScene(“SampleScene”);
    }
    public void OnMouseDownAsButtonStartSword1()
    {
        SceneManager.LoadScene(“New Scene1”);
    }
    public void OnMouseDownAsButtonStartSword2()
    {
        SceneManager.LoadScene(“New Scene2”);
    }
    public void OnMouseDownAsButtonStartSword3()
    {
        SceneManager.LoadScene(“New Scene3”);
    }

}
