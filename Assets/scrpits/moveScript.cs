using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{

    //   public Rigidbody2D body;
    //   public float speed;

    public float speed = 5;
    public Transform obj;

    public void FixedUpdate()
    {
        Physics.gravity = new Vector3(0, -1.0F, 0);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed/* * Time.deltaTime*/;
        obj.transform.position += tempVect;
    }
}


































//    // Start is called before the first frame update
//    void Start() {

//    }

//    void FixedUpdate() {
//        Vector3 velocity = new Vector3(0, 0);
//        if (Input.GetKeyDown("d"))
//        {   
//            velocity += new Vector3(speed, 0, 0);
//        }
//        if (Input.GetKeyDown("w"))
//        {
//            velocity += new Vector3(0, speed, 0);
//        }
//        if (Input.GetKeyDown("a"))
//        {
//            velocity += new Vector3(-speed, 0, 0);
//        }
//        if (Input.GetKeyDown("s"))
//        {
//            velocity += new Vector3(0,-speed, 0);
//        }

//        transform.position += velocity;
//    }
//}
