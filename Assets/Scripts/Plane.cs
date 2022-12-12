using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField] public float MaxSpeed = 30f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float Yaw = Input.GetAxis("Yaw");
        Vector3 movement = new Vector3(0.0f, MaxSpeed, -MaxSpeed);
        //rb.AddForce(movement);
        Vector3 rotation = new Vector3(moveHorizontal, moveVertical, Yaw);
        transform.Rotate(rotation / 5);
    }
}
