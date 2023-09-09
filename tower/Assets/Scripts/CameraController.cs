using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool doMovement = false;

    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    public float scrollSpeed = 5f;
    public float min_y = 10f;
    public float max_y = 80f;
    public float minX = 20f; // Minimum X coordinate
    public float maxX = 50f;  // Maximum X coordinate
    public float minZ = -90f; // Minimum Z coordinate
    public float maxZ = -40f;  // Maximum Z coordinate

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            doMovement = !doMovement;
        }

        if (!doMovement) return;

        Vector3 newPosition = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            newPosition += Vector3.forward * panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            newPosition -= Vector3.forward * panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            newPosition += Vector3.right * panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            newPosition -= Vector3.right * panSpeed * Time.deltaTime;
        }

        // Apply clamping to x and z coordinates
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);

        transform.position = newPosition;

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, min_y, max_y);

        transform.position = pos;
    }
}
