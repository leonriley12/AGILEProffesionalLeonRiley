using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ArrowGuide : MonoBehaviour
{
    public Transform arCamera;           // Reference to the AR Camera
    public Transform targetMarker;       // Reference to the current marker
    public GameObject arrowObject;       // Reference to the arrow prefab

    private void Update()
    {
        if (targetMarker != null && arrowObject != null && arCamera != null)
        {
            // Calculate the direction from the camera to the marker
            Vector3 direction = targetMarker.position - arCamera.position;
            direction.y = 0; // Ignore the vertical (Y) axis for horizontal alignment

            // Rotate the arrow to point in the direction of the marker
            arrowObject.transform.rotation = Quaternion.LookRotation(direction);
        }
    }

    public void SetTargetMarker(Transform newTarget)
    {
        targetMarker = newTarget;
        Debug.Log($"Arrow now pointing to: {newTarget.name}");
    }
}

