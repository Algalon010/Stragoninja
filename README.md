





![Str](https://github.com/user-attachments/assets/e2f4bb6d-a447-4c8f-968f-5f89a924fc0f)
![Str2](https://github.com/user-attachments/assets/387ec834-9b7e-4c1d-ab10-78328742a61e)
![Str1](https://github.com/user-attachments/assets/12dc21ef-7716-4c88-b571-7b611fe2d46f)




























# Все скрипты одним файлом
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTheGame  MonoBehaviour
{
    public GameObject Spriteclick;
    public GameObject Lose;
    public GameObject TheGame;
    public GameObject GameMusic;

    void Update()
    {
        if (Spriteclick == null)
        {
            Lose.SetActive(true);
            TheGame.SetActive(false);
            GameMusic.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCow : MonoBehaviour
{
    public GameObject Cube;
    public AudioSource _urce;
    public AudioClip _diesound;

    void Start()
    {
     _urce = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D Cube)
    {
        if (Cube.gameObject.CompareTag(“WorldM”)) ;
             {
                 _urce.PlayOneShot(_diesound);
             }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knopki : MonoBehaviour
{

    public GameObject TheGame;
    public GameObject StartGame;
    public GameObject Lose;
    public GameObject ChoseSwordGame;

    public void OnMouseDownAsButton()
     {
        SceneManager.LoadScene(“SampleScene”);
        TheGame.SetActive(false);
        ChoseSwordGame.SetActive(false);
        StartGame.SetActive(false);
        Lose.SetActive(false);
        Debug.Log(“Выполнен рестарт”);
     }  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knopki1  MonoBehaviour
{

    public GameObject TheGame;
    public GameObject StartGame;
    public GameObject Lose;
    public GameObject ChoseSwordGame;

    public void OnMouseDownAsButton()
    {
        SceneManager.LoadScene(“New Scene1”);
        TheGame.SetActive(false);
        ChoseSwordGame.SetActive(false);
        StartGame.SetActive(false);
        Lose.SetActive(false);
        Debug.Log(“Выполнен рестарт”);
    

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knopki3  MonoBehaviour
{
    public GameObject TheGame;
    public GameObject StartGame;
    public GameObject Lose;
    public GameObject ChoseSwordGame;

    public void OnMouseDownAsButton()
    {
        SceneManager.LoadScene(“New Scene3”);
        TheGame.SetActive(false);
        ChoseSwordGame.SetActive(false);
        StartGame.SetActive(false);
        Lose.SetActive(false);
        Debug.Log(“Выполнен рестарт”);
    }
}

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate  MonoBehaviour
{
        void Start()
        {
        
        }
        void Update()
        {
            transform.Rotate(new Vector3(0, 0, -3));
        }
 	}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public Transform target;
    public GameObject Spriteclick;
    public GameObject Cube;
    public float fast;

    void Start()
    {
        if (Spriteclick)
        {
            target = GameObject.FindWithTag(“qwer”).transform;
        }
    }
    public void Update()
    {
        if (Spriteclick)
        {
            transform.position = Vector2.MoveTowards(transform.position, Spriteclick.transform.position, fast * Time.deltaTime);
        }
        if (Spriteclick)
        {
        float angle = 0;
        Vector3 relative = transform.InverseTransformPoint(target.position);
        angle = Mathf.Atan2(relative.x, relative.y) * Mathf.Rad2Deg;
        transform.Rotate(0, 0, -angle - 90);
        }
    }
    public void OnTriggerEnter2D(Collider2D coll)
    {
		 if (Spriteclick)
        {
            Destroy(Cube);
            Debug.Log(“Удалить птицу”);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCow : MonoBehaviour
{
    public GameObject PartPosCow;
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(Instantiate(PartPosCow, transform.position, Quaternion.identity), 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFish : MonoBehaviour
{
    public AudioSource _source;
    public AudioClip _fishsound;
    public bool vxod = true;
    public GameObject PartPos;

    void Start()
    {
        _source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collaid)
    {
     	if(vxod)
     	{
       		 _source.PlayOneShot(_fishsound);
    		Destroy(Instantiate(PartPos, transform.position, Quaternion.identity), 1f);
     	}
    }   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner  MonoBehaviour
{
    public GameObject Spriteclick;
    public Transform[] SpawnPos;
    public GameObject Cube;
    public float TimeSpawn;

    void Start()
    {
     StartCoroutine(SpawnCD());
    }
    void Repeat()
    {
        if (Spriteclick)
        {
          StartCoroutine(SpawnCD());
        }
    }
    IEnumerator SpawnCD()
    {
        TimeSpawn = Random.Range(1.5f, 3f);
        yield return new WaitForSeconds(TimeSpawn);
        int qwe = Random.Range(0, SpawnPos.Length);
        Cube.GetComponentRun().fast = Random.Range(5f, 7f);
        Destroy(Instantiate(Cube, SpawnPos[qwe].position, transform.rotation), 10f);

        if (Cube = null) если включить эту функцию кубики летят в место нужное 1 раз 
        Repeat();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTwo : MonoBehaviour
{
    public GameObject Spriteclick;
    public Transform[] SpawnPosTwo;
    public GameObject Cube;
    public float TimeSpawnTwo;
    public int i;

    void Start()
    {
      StartCoroutine(SpawnDC());
    }

    void Repeat()
    {
        if (Spriteclick)
        {
            StartCoroutine(SpawnDC());
        }
    }
    IEnumerator SpawnDC()
    {
        TimeSpawnTwo = Random.Range(5f, 9f);
        yield return new WaitForSeconds(TimeSpawnTwo);
        int rty = Random.Range(0, SpawnPosTwo.Length);
        Cube.GetComponent<Run>().fast = Random.Range(4f, 7f);
        Destroy(Instantiate(Cube, SpawnPosTwo[rty].position, transform.rotation), 10f);
        Repeat();
    }
}

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sworder1 : MonoBehaviour
{
    public GameObject Sword1;
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
            Sword1.transform.position = mouseposition;
        }
    }
}

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

TextFlash.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFlash : MonoBehaviour
{
   public float clock;
   
    void Update()
    {
        clock += Time.deltaTime;
        if (clock >= 0.5)
        {
        	GetComponent<Text>().enabled =false;
        }
        if (clock >= 1)
        {
            GetComponent<Text>().enabled =true;
            clock=0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger  MonoBehaviour
{
    public GameObject Spriteclick;
    public bool enter = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (enter)
        {
            Debug.Log(“Рыбка уничтожена”);
            Destroy(Spriteclick);
        }
    }      
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour { 
	
public GameObject GameMusic;
	public GameObject ScoreHide; 
    public GameObject StartGame; 
    public GameObject TheGame;
    public GameObject White;
    public GameObject ManRun;
    public GameObject ManDownn;
    public GameObject ManDown;
    public GameObject FonNiz;
    public GameObject FonRun;
    public GameObject TheGameRun;
    public GameObject NameGameStart;
    public Transform target;
    public Transform targetfish;
    public Transform targetfon;
    public Transform targetgame;
    public GameObject FishUp;
    public GameObject FishRun;
    public GameObject TouchText;
    public float mrun = 3f;
    public float mrunn =50f;
    public float frun = 6f;
    public float fonrun =7f;
    public float gamerun =3f;
    
    void Start()
    {
        Invoke(“Two”, 1f);  
    }
    void Two()
    {
       White.SetActive(false);
    }
    public void OnMouseDownAsButtonStart()
    {
    	Invoke(“Five”, 0.01f);
    	Invoke(“Six”, 0.5f);
    	Invoke(“Tree”, 1.2f);
    }
    void Six()
    {
    	GameMusic.SetActive(true);
    }
    void Tree()
    {       
    	TheGame.SetActive(true);
        StartGame.SetActive(false);
        Debug.Log(“Старт выполнен!”);
    }
    void Five()
    {
    	ManDownn.GetComponent<Animator>().SetBool(“Enter”,true);
    	TouchText.SetActive(false);
    	NameGameStart.SetActive(false);
    	ScoreHide.SetActive(true);
    }
    public void OnMouseDownAsButtonStartMan()
    {
        StartCoroutine(ManCD());
    }


    void Repeat()
    {
        StartCoroutine(ManCD());
    }

    IEnumerator ManCD()
    {
        yield return null;
        ManDownn.transform.position = Vector2.MoveTowards(ManDownn.transform.position, ManRun.transform.position, mrun * Time.deltaTime);
        ManDown.transform.position = Vector2.MoveTowards(ManDownn.transform.position, ManRun.transform.position, mrunn * Time.deltaTime);
        FishUp.transform.position = Vector2.MoveTowards(FishUp.transform.position, FishRun.transform.position, frun * Time.deltaTime);
        FishUp.transform.Rotate(new Vector3(0, 0, -5));
        FonNiz.transform.position = Vector2.MoveTowards(FonNiz.transform.position, FonRun.transform.position, fonrun * Time.deltaTime);
        NameGameStart.transform.position = Vector2.MoveTowards(NameGameStart.transform.position, TheGameRun.transform.position, gamerun * Time.deltaTime);
        Repeat();
    }
}
