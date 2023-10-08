using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;



public class SimplerCameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    private float speed = 0.5f;
    private int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 0.5f;
        direction = 0;
        if(Input.GetKey(KeyCode.A))
        {
            direction = -1;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            direction = 1;
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 1.0f;
        }
        transform.LookAt(target);
        transform.Translate(speed * direction * Vector3.right * Time.deltaTime);
    }
}
