using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// vaules for forward speed and turnspeed
public class Move : MonoBehaviour
{
    private float speed = 30.0f;

    private float turnspeed = 35.0f;

    // Horizontal and vertaical inputs

    private float Hinput;
    private float Vinput;

    // Update is called once per frame
    void Update()
    {
        Hinput = Input.GetAxis("Horizontal");
        Vinput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * Vinput);
        transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * Hinput);
    }
}
