using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    
    private GameObject Scoreboard;
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.Scoreboard = GameObject.Find("ScoreBoard");
    }



    void OnCollisionEnter(Collision collision)
    {
       
            string tag = collision.gameObject.tag;
            if (tag == "SS")
            {
                Score += 5;
            }

            else if (tag == "LS")
            {
                Score += 10;
            }
            else if (tag == "SC")
            {
               Score += 40;
            }
            else if (tag == "LC")
            {
               Score += 20;
            }
            

            this.Scoreboard.GetComponent<Text>().text = "Score:" + this.Score;
        

    }
}
