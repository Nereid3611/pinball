using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;


public class Fripper : MonoBehaviour
{
    //Hingeコンポーネントとの紐づけ
    private HingeJoint myHingeJoint;
    //初期角度
    private float defaultAngle = 20;
    //動作後の位置
    private float flickAngle = -20;


    // Start is called before the first frame update
    void Start()
    {
    　　//Hingeコンポーネントの取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {    //　　　キー押し込み（→）　
        if(Input.GetKeyDown(KeyCode.RightArrow) && tag == "RF")
        { SetAngle(this.flickAngle); }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LF")
        { SetAngle(this.flickAngle); }
        if(Input.GetKeyUp(KeyCode.RightArrow) && tag == "RF")
        { SetAngle(this.defaultAngle); }
        if(Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LF")
        { SetAngle(this.defaultAngle); }
    }
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

    }

}

