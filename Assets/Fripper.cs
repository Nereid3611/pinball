using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using directive;


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
        this.myHingeJoint = GetComponent<myHingeJoint>();

        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {    //　　　キー押し込み（→）　
        if(Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        { SetAngle(this.flickAngle); }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        { SetAngle(this.flickAngle); }
        if(Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        { SetAngle(this.defaultAngle); }
        if(Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        { SetAngle(this.defaultAngle); }
    }
    public void SetAngle(float angle)
    {
        JointSpring joinSpr = this.myHingeJoint.spring;
        JointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

    }

}

