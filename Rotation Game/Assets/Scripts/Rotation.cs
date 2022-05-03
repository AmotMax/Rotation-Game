using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float speed, cameraSpeed;
    public bool canControl;
    public Transform cam;

    public SpriteRenderer Z, Q, S, D;

    // Start is called before the first frame update
    void Start()
    {
        canControl = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) && canControl )
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
            Z.color = new Color(0, 1, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {            
            Z.color = new Color(1, 1, 1);
        }

        if (Input.GetKey(KeyCode.S) && canControl)
        {
            transform.Rotate(-speed* Time.deltaTime, 0, 0);
            S.color = new Color(0, 1, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            S.color = new Color(1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Q) && canControl)
        {
            transform.Rotate(0, -speed * Time.deltaTime, 0);
            Q.color = new Color(0, 1, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Q.color = new Color(1, 1, 1);
        }

        if (Input.GetKey(KeyCode.D) && canControl)
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
            D.color = new Color(0, 1, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            D.color = new Color(1, 1, 1);
        }






        if (Input.GetKey(KeyCode.LeftArrow))
        {
            cam.transform.Rotate(0, -cameraSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            cam.transform.Rotate(0, cameraSpeed * Time.deltaTime, 0);
        }


    }
}
