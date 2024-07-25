using UnityEngine;

public class SimpleCameraRotationController : MonoBehaviour
{
    public Transform objectToRotate; // The object to rotate
    public float rotationSpeed = 5.0f; 

    private float yaw = 0.0f; // Rotation around the Y axis
    private float pitch = 0.0f; // Rotation around the X axis

    void Update()
    {
        // Check if the right mouse button is held down
        if (Input.GetMouseButton(1))
        {
            // Get the mouse input
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // Calculate the new rotation
            yaw += mouseX * rotationSpeed;
            pitch -= mouseY * rotationSpeed;

            // Clamp the pitch to prevent flipping
            pitch = Mathf.Clamp(pitch, -90f, 90f);

            // Apply the rotation to the object
            if (objectToRotate != null)
            {
                objectToRotate.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
        }
    }
}

