using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{

    public PathCreator pathCreator;
    public EndOfPathInstruction endOfPathInstruction;
    public float speed = 0.3f;
    float distanceTravelled;
    public bool touchOrNot;

    public void Start()
    {
        touchOrNot = false;
        speed = 0.25f;
    }

    public void Update()
    {
        if (pathCreator!=null&&touchOrNot)
        {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled,endOfPathInstruction);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled,endOfPathInstruction);
            if (this.gameObject.GetComponent<Transform>().position.z<-56.9999f&& this.gameObject.GetComponent<Transform>().position.z>-57f)
            {
                touchOrNot = false;
            }
        

        }

    }
}
