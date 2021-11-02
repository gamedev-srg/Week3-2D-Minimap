using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            Vector3 position = this.transform.position;
            position.x-= 0.015f;
            this.transform.position = position;
        }
        if (Input.GetKey("right"))
        {
            Vector3 position = this.transform.position;
            position.x += 0.015f;
            this.transform.position = position;
        }
        if (Input.GetKey("up"))
        {
            Vector3 position = this.transform.position;
            position.y += 0.015f;
            this.transform.position = position;
        }
        if (Input.GetKey("down"))
        {
            Vector3 position = this.transform.position;
            position.y -= 0.015f;
            this.transform.position = position;
        }
    }
}
