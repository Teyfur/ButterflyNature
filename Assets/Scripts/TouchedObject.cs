using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedObject : MonoBehaviour
{
    [SerializeField]
    private GameObject butterfly1;

    [SerializeField]
    public GameObject touchedObj;

    [SerializeField]
    private Camera camera1;

    [SerializeField]
    public GameObject Path;    

    private void Update()
    {
        if (Input.touchCount>0)
        {
            Touch inputtouch = Input.GetTouch(0);


            RaycastHit touchedObject1;

            if (Physics.Raycast(camera1.ScreenPointToRay(inputtouch.position), out touchedObject1))
            {
                if (touchedObject1.collider.gameObject.name == "GameObject")
                {
                    print("butterfly");
                    this.gameObject.GetComponent<Follower>().touchOrNot = true;
                }
                touchedObj = touchedObject1.collider.gameObject;
            }


        }
    }

}
