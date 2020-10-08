using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudcontroller : MonoBehaviour
{
    //基本サイズ
    private float minimum = 1.0f;
    //変化速度
    private float magSpeed = 10.0f;
    //拡大率
    private float magnification = 0.07f;

    void Start()
    {

    }

    void Update()
    {

      this.transform.localScale =  new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
    }
}