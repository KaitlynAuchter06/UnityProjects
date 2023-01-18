using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlaneController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed = 30.0f;
    public float verticalInput;
    public float forwardInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") > 0.0)
        { //if the right arrow is pressed
            transform.Rotate((float)0.0, turnSpeed * Time.deltaTime, (float)(-10.0 * Time.deltaTime)); //and then turn the plane
        }
        if (Input.GetAxis("Horizontal") < 0.0)
        { //if the left arrow is pressed
            transform.Rotate((float)0.0, -turnSpeed * Time.deltaTime, (float)(10.0 * Time.deltaTime)); //The X-rotation turns the plane - the Z-rotation tilts it
        }
                horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move Vehicle Forward Based On Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotates Vehicle Based On Horizontal Input
        transform.Rotate(Vector3.up, speed * horizontalInput * Time.deltaTime);

        //Rotates Vehicle Based On Horizontal Input
        transform.Rotate(Vector3.down, speed * horizontalInput * Time.deltaTime);

        //move the plane forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //move the plane backwards
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
