using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalValue : MonoBehaviour
{
    //Range to be changed according to level\difficulty
    public int ValueRange_Min = 0;
    public int ValueRange_Max = 10;

    public int GoalValueNumber;
    public int BigSphere;
    public TMP_Text Text;

    void Start()
    {
        BigSphere = Random.Range(1, 4);

        Text = this.GetComponent<TMP_Text>();
        //Choosing and assigning text according to Range
        GoalValueNumber = Random.Range(ValueRange_Min, ValueRange_Max);
        Text.text = GoalValueNumber.ToString();
    }

}
