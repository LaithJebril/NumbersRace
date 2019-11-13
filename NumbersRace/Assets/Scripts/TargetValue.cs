using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetValue : MonoBehaviour
{
    int BigSphere;
    public GameObject Sphere;
    //To Do : SphereNum should be connected to a randomized Num
    public int SphereNum;

    public TMP_Text Text;
    public int ValueRange_Min = 0;
    public int ValueRange_Max = 10;
    public int TargetValueNum;
    GameObject GoalValue;

    void Start()
    {
        SphereNum = Sphere.GetComponent<TargetLabel>().Label;
        GoalValue = GameObject.FindGameObjectWithTag("GoalValue");
        BigSphere = GoalValue.GetComponent<GoalValue>().BigSphere;
        Debug.Log("GOAL :" + GoalValue.GetComponent<GoalValue>().GoalValueNumber);
        Debug.Log(BigSphere);




        Text = this.GetComponent<TMP_Text>();
        //Choosing and assigning text according to Range
        TargetValueNum = Random.Range(ValueRange_Min, ValueRange_Max);
        Text.text = TargetValueNum.ToString();
    }
    void Update()
    {
        if (SphereNum == BigSphere)
        {
            Debug.Log(GoalValue.GetComponent<GoalValue>().GoalValueNumber);
            ValueRange_Min = GoalValue.GetComponent<GoalValue>().GoalValueNumber;
        }
       
    }
}
