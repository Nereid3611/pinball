using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour
{
    Material myMaterial;
    private float minEm = 0.3f;
    //mag=強度
    private float magEm = 2.0f;

    private int Deg = -10;
    private int Sp = 10;
    //ラージクラウドのデフォ色
    Color defaultcolor = Color.white;


    // 初期色の設定
    void Start()
    {
        if (tag == "SS")
        {
            this.defaultcolor = Color.white;
        }
        else if (tag == "LS")
        {
            this.defaultcolor = Color.yellow;
        }
        else if (tag =="SC")
        {
            this.defaultcolor = Color.cyan;
        }

        this.myMaterial = GetComponent<Renderer>().material;

        myMaterial.SetColor("_EmissionColor", this.defaultcolor * minEm);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.Deg >= 0)
        {
            //点滅強度
            Color EmissionColor = this.defaultcolor * (this.minEm + Mathf.Sin(this.Deg * Mathf.Deg2Rad) * magEm);
            myMaterial.SetColor("_EmissionColor", EmissionColor);
            //1Fずつ消化
            this.Deg -= this.Sp;
        }
    }
    
    void OnCollisionEnter(Collision other)
    {
        

        //18F分
        this.Deg = 180;
    }
}
