using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShipController : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeedX = 1.0f;
    public float rotationSpeedY = 1.0f;
     
    void Update() {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;

        Vector3 rotate = new Vector3(-Input.GetAxis("Vertical") * rotationSpeedY, Input.GetAxis("Horizontal") * rotationSpeedX, 0);
        transform.localEulerAngles += rotate * Time.deltaTime;
        //Debug.Log(rotate * Time.deltaTime);
    }
}
