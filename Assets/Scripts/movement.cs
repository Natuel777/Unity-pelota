using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 6f;
    Vector3 posInicial;
    Vector3 input;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posInicial = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        rb.AddForce(input*moveSpeed);

        if(transform.position.y<-2){
            Respawn();
        }
    }

    void Respawn(){
        transform.position = posInicial;
    }
}
