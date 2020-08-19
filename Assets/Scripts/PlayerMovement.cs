using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    
        
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

     void Update()
    {
       float horMove = Input.GetAxis("Horizontal");

        rbPlayer.AddForce(new Vector3(horMove, 0, 0),ForceMode.Impulse);
    }
}
