using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    private float offset = 2f;
    GameObject player;
    void Start()
    {
        player = GameObject.Find("Bola");
        transform.Rotate(70,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y +6, player.transform.position.z - offset);
        
    }
}
