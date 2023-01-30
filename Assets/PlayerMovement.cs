using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour 
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float speed, angularspeed;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   Debug.Log(this.IsOwner);
        if(!this.IsOwner) return;

        
        if (Input.GetKey(KeyCode.W)){
            rb.velocity += (this.transform.forward) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)){
            rb.angularVelocity += new Vector3(0,angularspeed* Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.angularVelocity -= new Vector3(0,angularspeed* Time.deltaTime,0);
        }

        
        
    }
}
