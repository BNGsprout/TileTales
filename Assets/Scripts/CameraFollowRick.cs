using UnityEngine;

public class CameraFollowRick : MonoBehaviour
{
    public Transform target;
    public Vector2 offset = new Vector2(0, 0); // Use Vector2 for 2D logic
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target != null)
        {
            // 1. Calculate position using Vector2
            Vector2 desiredPosition2D = (Vector2)target.position + offset;
            
            // 2. Convert current position to Vector2 for Lerp
            Vector2 currentPos2D = (Vector2)transform.position;
            
            // 3. Smooth movement in 2D space
            Vector2 smoothedPosition2D = Vector2.Lerp(currentPos2D, desiredPosition2D, smoothSpeed);
            
            // 4. Assign back to Transform (Implicitly converts to Vector3, keeping Z intact)
            transform.position = new Vector3(smoothedPosition2D.x, smoothedPosition2D.y, transform.position.z);
            
            // Lock rotation
            transform.rotation = Quaternion.identity; 
        }
    }
}
