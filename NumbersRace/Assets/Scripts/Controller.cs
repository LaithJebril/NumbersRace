using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float Speed;
    private Vector2 LastTapPos;
    private Vector3 startPos;

    private void Awake()
    {
        startPos = transform.position;
        
    }
    private void Update()
    {
        
        //ForDeletionLater

        //this.GetComponent<Rigidbody>().AddForce(Vector3.forward * -.1f);

        //SurfingLeftAndRight 
        if (Input.GetMouseButton(0))
        {
            Vector2 curTapPos = Input.mousePosition;
            if(LastTapPos == Vector2.zero)
            {
                LastTapPos = curTapPos;
            }
            float delta = LastTapPos.x - curTapPos.x;
            LastTapPos = curTapPos;
            transform.Translate(Vector3.right * delta * -Speed);
        }
        if (Input.GetMouseButtonUp(0))
        {
            LastTapPos = Vector2.zero;
        }
    }
}
