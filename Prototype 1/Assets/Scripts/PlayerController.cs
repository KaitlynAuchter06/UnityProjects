using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move Vehicle Forward Based On Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates Vehicle Based On Horizontal Input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
