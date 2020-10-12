using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject Gameovertext;

    // Start is called before the first frame update
    void Start()
    {
        this.Gameovertext = GameObject.Find("GameOver");

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ)
        {
            this.Gameovertext.GetComponent<Text>().text = "Game Over";
        }
    }
}
