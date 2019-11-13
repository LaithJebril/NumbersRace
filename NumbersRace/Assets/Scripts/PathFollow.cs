using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    public GameObject Player;

    Node[] PathNode;
    float Timer;
    public float MovSpeed;
    //Vector3 to hold the Node's location
    static Vector3 CurrPositionHolder;
    //Hold whichever node is current on the path
    int CurrentNode;

    void Start()
    {
        PathNode = GetComponentsInChildren<Node>();
        CheckNode();
        foreach (Node n in PathNode)
        {
            Debug.Log(n.name);
        }
    }
    void CheckNode()
    {
        CurrPositionHolder = PathNode[CurrentNode].transform.position;
    }
    void Update()
    {
        Debug.Log(CurrentNode);
        Timer += Time.deltaTime * MovSpeed;

        if(Player.transform.position != CurrPositionHolder)
        {
            Player.transform.position = Vector3.Lerp(Player.transform.position, CurrPositionHolder, Timer);
        }
        else
        {
            if(CurrentNode < PathNode.Length )
            {
                CurrentNode++;
                CheckNode();
            }
           
        }
    }
}
