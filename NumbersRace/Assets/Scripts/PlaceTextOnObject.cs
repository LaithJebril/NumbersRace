using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlaceTextOnObject : MonoBehaviour
{
    public GameObject TargetPlace;
   void Update()
   {
       Vector3 Pos = Camera.main.WorldToScreenPoint(TargetPlace.transform.position);
       this.gameObject.transform.position = Pos;
   }
}
