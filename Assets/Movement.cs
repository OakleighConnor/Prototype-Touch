using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public FixedJoystick js;

    public int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb);
        Debug.Log(js.Horizontal);
        rb.velocity = new Vector3(js.Horizontal * moveSpeed, rb.velocity.y, js.Vertical * moveSpeed);

        if(js.Horizontal != 0 || js.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
    }
}
