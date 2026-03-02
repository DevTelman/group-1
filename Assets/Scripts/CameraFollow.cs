using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    public float smoothSpeed = 0.125f; // The speed of the camera's movement
    public Vector3 offset; // The offset from the target's position
    private bool isInitialized = false; // Track if camera position has been initialized

    void Start()
    {
        // Calculate offset based on current camera position - target position
        if (target != null)
        {
            offset = transform.position - target.position;
            transform.LookAt(target);
            isInitialized = true;
        }
    }

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset; // Calculate the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smoothly interpolate to the desired position
            transform.position = smoothedPosition; // Update the camera's position

            transform.LookAt(target); // Make the camera look at the target
        }
    }
}
