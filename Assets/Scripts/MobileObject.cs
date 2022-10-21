using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileObject : MonoBehaviour

{
    //[SerializeField]
    //private GameObject cube;

    public GameObject touchedobj;

    public Camera camera1;
    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch inputtouch = Input.GetTouch(0);
           // Vector2 touchposition = Camera.main.ScreenToWorldPoint(inputtouch.position);
            //Instantiate(cube, touchposition, Quaternion.identity);
            //print(inputtouch.position);

            RaycastHit touchedObject;

            if (Physics.Raycast(camera1.ScreenPointToRay(inputtouch.position), out touchedObject))
            {
                if (touchedObject.collider.gameObject.name=="Cube")
                {
                    print("cube");
                }
                touchedobj = touchedObject.collider.gameObject;
            }

            // touch began
            /*
            if (inputtouch.phase == TouchPhase.Began)
            {
                Collider[] touchedcollider = Physics.OverlapSphere(touchposition, 0.5f);
                if (touchedcollider.Length > 0)
                {
                    touchedobj = touchedcollider[0].gameObject;
                }

            }

            //touch move
            if (inputtouch.phase == TouchPhase.Moved)
            {
                if (touchedobj != null)
                    touchedobj.transform.position = touchposition;
            }

            if (inputtouch.phase == TouchPhase.Ended)
            {
                if (touchedobj != null)
                    touchedobj = null;
            }*/
        }
    }
}

