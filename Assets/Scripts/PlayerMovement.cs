using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Vector3 direction = Vector3.zero;
    public float speed = 10.0f;
    
        
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horMove = Input.GetAxis("Horizontal");
        float verMove = Input.GetAxis("Vertical");

        direction = new Vector3(horMove, 0, verMove);
    }

    void FixedUpdate()
    {
       
       rbPlayer.AddForce(direction * speed,ForceMode.Force);
    }
}
