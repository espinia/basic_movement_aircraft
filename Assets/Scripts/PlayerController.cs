using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed=10f;
    public float rotationSpeed = 45f;

    float verticalInput;
    float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed*Time.deltaTime);
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput*Time.deltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);

    }
}
