using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformTest : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        float i = 0;
        i += Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        transform.Translate(i*5, i, i);
    }

}
