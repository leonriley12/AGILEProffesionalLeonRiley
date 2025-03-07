using UnityEngine;

public class ARArrowController : MonoBehaviour
{
    public Transform arrowObject; // Reference to the arrow object
    public CoordinateList coordinateList; // Reference to the CoordinateList ScriptableObject
    public UserLocation userLocation; // Reference to the UserLocation script
    private int currentBuildingIndex; // Store the current target building index

    void Start()
    {
        // Start the repeated updates every second
        InvokeRepeating("UpdateArrowDirection", 0f, 1f);

        // Debug logs to check references
        Debug.Log("ARArrowController Start method called");
        if (arrowObject == null) Debug.LogError("arrowObject is not assigned!");
        if (coordinateList == null) Debug.LogError("coordinateList is not assigned!");
        if (userLocation == null) Debug.LogError("userLocation is not assigned!");
    }

    public void SetTargetBuilding(int buildingIndex)
    {
        if (buildingIndex >= 0 && buildingIndex < coordinateList.coordinates.Count)
        {
            currentBuildingIndex = buildingIndex; // Set the current target building index
        }
        else
        {
            Debug.LogError("Invalid building index!");
        }
    }

    public void UpdateArrowDirection()
    {
        if (currentBuildingIndex >= 0 && currentBuildingIndex < coordinateList.coordinates.Count)
        {
            // Get the target building coordinate from the CoordinateList ScriptableObject
            CoordinateData targetCoordinate = coordinateList.coordinates[currentBuildingIndex];

            // Debug log to verify coordinates
            Debug.Log($"Target Building: {targetCoordinate.name}, Latitude: {targetCoordinate.latitude}, Longitude: {targetCoordinate.longitude}");

            // Convert latitude and longitude to a Vector3 (assuming this is already done)
            Vector3 targetPosition = new Vector3((float)targetCoordinate.latitude, 0, (float)targetCoordinate.longitude);

            // Calculate the direction from the user's current position to the target position
            Vector3 direction = targetPosition - userLocation.currentLocation;

            // Update the arrow's rotation to point towards the target position
            arrowObject.rotation = Quaternion.LookRotation(direction);
        }
        else
        {
            Debug.LogError("Invalid building index!");
        }
    }
}
