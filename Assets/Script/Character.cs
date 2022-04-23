using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public Transform Slides1, Slides2, Door1, Door2, Barrier1, Barrier2, Barrier3, Barrier4,Barrier5,Barrier6,Barrier7, Coin1,Coin2,Coin3,Coin4,Coin5,Coin6,Coin7;
    public GameObject textScore;
    private Text Score;
    public int AllCoin;

    [SerializeField]
    private float forwardSpeed;
    public float verticalMove;
    Vector3 firstPos, endPos;

    void Start()
    {
        Score = textScore.GetComponent<Text>();
        AllCoin = 0;
    }
    void Update()
    {
        //Hareket Kodlarý:
        float horizontal = Input.GetAxis("Horizontal") * forwardSpeed * Time.deltaTime;
        this.transform.Translate(horizontal, 0, forwardSpeed*Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
            Time.timeScale = 1;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float differenceX = endPos.x - firstPos.x;
            transform.Translate(differenceX * Time.deltaTime * verticalMove, 0, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        // Sonsuz yapma:
        if (other.gameObject.name == "Door1")
        {
            Slides1.position = new Vector3(Slides2.position.x, Slides2.position.y, Slides2.position.z + 110f);
            Door1.position = new Vector3(Door2.position.x, Door2.position.y, Door2.position.z + 110f);
            Barrier1.position = new Vector3(Barrier1.position.x, Barrier1.position.y, Barrier1.position.z + 220f);
            Barrier2.position = new Vector3(Barrier2.position.x, Barrier2.position.y, Barrier2.position.z + 220f);
            Barrier3.position = new Vector3(Barrier3.position.x, Barrier3.position.y, Barrier3.position.z + 220f);
            Barrier4.position = new Vector3(Barrier4.position.x, Barrier4.position.y, Barrier4.position.z + 220f);
        }
        if (other.gameObject.name == "Door2")
        {
            Slides2.position = new Vector3(Slides1.position.x, Slides1.position.y, Slides1.position.z + 110f);
            Door2.position = new Vector3(Door1.position.x, Door1.position.y, Door1.position.z + 110f);
            Barrier5.position = new Vector3(Barrier5.position.x, Barrier5.position.y, Barrier5.position.z + 220f);
            Barrier6.position = new Vector3(Barrier6.position.x, Barrier6.position.y, Barrier6.position.z + 220f);
            Barrier7.position = new Vector3(Barrier7.position.x, Barrier7.position.y, Barrier7.position.z + 220f);
        }

        //Oyunu Kaybetme:
        if (other.gameObject.name == "Plane")
        {
            SceneManager.LoadScene("Game over");
        }
        if (other.gameObject.tag == "barrier")
        {
            SceneManager.LoadScene("Game over");
        }


        // Coinler ve Skor:
        if (other.gameObject.name == "Coin1")
        {
            Coin1.position = new Vector3(Coin1.position.x, Coin1.position.y, Coin1.position.z + 330f);
            AllCoin+=10;
            Score.text = "Score:" + AllCoin;
        }
        if (other.gameObject.name == "Coin2")
        {
            Coin2.position = new Vector3(Coin2.position.x, Coin2.position.y, Coin2.position.z + 300f);
            AllCoin+=10;
            Score.text = "Score:" + AllCoin;
        }
        if (other.gameObject.name == "Coin3")
        {
            Coin3.position = new Vector3(Coin3.position.x, Coin3.position.y, Coin3.position.z + 300f);
            AllCoin+=10;
            Score.text = "Score:" + AllCoin;
        }
        if (other.gameObject.name == "Coin4")
        {
            Coin4.position = new Vector3(Coin4.position.x, Coin4.position.y, Coin4.position.z + 300f);
            AllCoin+=10;
            Score.text = "Score:" + AllCoin;
        }
        if (other.gameObject.name == "Coin5")
        {
            Coin5.position = new Vector3(Coin5.position.x, Coin5.position.y, Coin5.position.z + 200f);
            AllCoin+=10;
            Score.text = "Score:" + AllCoin;
        }
        if (other.gameObject.name == "Coin6")
        {
            Coin6.position = new Vector3(Coin6.position.x, Coin6.position.y, Coin6.position.z + 300f);
            AllCoin+=10;
            Score.text = "Score:" + AllCoin;
        }
        if (other.gameObject.name == "Coin7")
        {
            Coin7.position = new Vector3(Coin7.position.x, Coin7.position.y, Coin7.position.z + 500f);
            AllCoin+=10;
            Score.text = "Score:" + AllCoin;
        }
        

    }
}