using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private bool doMovement = true;


    public float panSpeed = 30f;
    public float panBorderThicknes = 10f;

    public float scrollSpeed = 5f;

    public float min_y = 10f;
    public float max_y = 80f;
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){
            doMovement = !doMovement;
        }

        if (!doMovement) return;

        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThicknes){
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey("s") || Input.mousePosition.y <= panBorderThicknes){
            transform.Translate(-Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThicknes){
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if(Input.GetKey("a") || Input.mousePosition.x <= panBorderThicknes){
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y-= scroll*1000*scrollSpeed*Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y,min_y,max_y);

        transform.position = pos;
    }
}