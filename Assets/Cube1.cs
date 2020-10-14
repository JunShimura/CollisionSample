using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    [SerializeField]
    Transform sphereTransform;
    [SerializeField]
    Vector3 moveVector = new Vector3(0.0625f,0, 0);
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
       transform.Translate(moveVector);
        if ((sphereTransform.position - transform.position).magnitude < 1.0f)
        {
            Debug.Log("ぶつかった！");
            this.transform.position = sphereTransform.position + new Vector3(-1.0f, 0, 0);
            moveVector = Vector3.zero;
        }
    }
    private void FixedUpdate()
    {
        //rb.MovePosition(transform.position+ moveVector);
        //rb.AddForce(moveVector,ForceMode.VelocityChange);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnTrigerEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
}
