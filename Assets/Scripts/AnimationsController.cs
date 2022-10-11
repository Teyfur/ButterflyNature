using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsController : MonoBehaviour
{
    
    private void Update()
    {
        float speed = Mathf.Abs(Input.GetAxisRaw("Horizontal"));
            GetComponent<Animator>().SetFloat("Speed",speed);
        print(speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("FirstAnimation");

        }
    }
}
