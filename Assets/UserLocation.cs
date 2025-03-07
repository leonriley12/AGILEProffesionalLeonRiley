using UnityEngine;

public class UserLocation : MonoBehaviour
{
    public Vector3 currentLocation; // User's current location in the scene

    void Start()
    {
        // Check if location services are enabled
        if (Input.location.isEnabledByUser)
        {
            Input.location.Start();
            InvokeRepeating("UpdateLocation", 0f, 1f); // Start updating the location every second
        }
        else
        {
            Debug.Log("Location services are not enabled.");
            // Optional: Prompt the user to enable location services
        }
    }

    void UpdateLocation()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            currentLocation = new Vector3(
                (float)Input.location.lastData.latitude,
                0,
                (float)Input.location.lastData.longitude);
        }
        else
        {
            Debug.Log("Unable to determine device location.");
        }
    }
}

