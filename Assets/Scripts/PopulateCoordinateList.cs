using UnityEngine;

public class PopulateCoordinateList : MonoBehaviour
{
    public CoordinateList coordinateList; // Assign your CoordinateList ScriptableObject here
    public AudioClip defaultAudioClip; // Optional: Use a default audio clip for all buildings

    void Start()
    {
        // Create an array of CoordinateData for the buildings
        CoordinateData[] buildingCoordinates = new CoordinateData[]
        {
            new CoordinateData { name = "Adelphi", latitude = 53.7643816, longitude = -2.7081326, audioClip = defaultAudioClip },
            new CoordinateData { name = "Allen", latitude = 53.7650932, longitude = -2.7072012, audioClip = defaultAudioClip },
            new CoordinateData { name = "Allen (next to Harrington)", latitude = 53.7652603, longitude = -2.7072940, audioClip = defaultAudioClip },
            new CoordinateData { name = "Brook", latitude = 53.7660631, longitude = -2.7078603, audioClip = defaultAudioClip },
            new CoordinateData { name = "Chandler", latitude = 53.7610496, longitude = -2.7068163, audioClip = defaultAudioClip },
            new CoordinateData { name = "C + T", latitude = 53.7635551, longitude = -2.7089389, audioClip = defaultAudioClip },
            new CoordinateData { name = "Darwin", latitude = 53.7606458, longitude = -2.7086261, audioClip = defaultAudioClip },
            new CoordinateData { name = "Eden", latitude = 53.7662276, longitude = -2.7069316, audioClip = defaultAudioClip },
            new CoordinateData { name = "Edward", latitude = 53.7609903, longitude = -2.7076293, audioClip = defaultAudioClip },
            new CoordinateData { name = "EIC", latitude = 53.7624457, longitude = -2.7080353, audioClip = defaultAudioClip },
            new CoordinateData { name = "Student Center", latitude = 53.7629384, longitude = -2.7073779, audioClip = defaultAudioClip },
     
            new CoordinateData { name = "tester", latitude = 53.7445367, longitude = -2.3552414, audioClip = defaultAudioClip },
            
        };

        // Clear any existing data in the CoordinateList
        coordinateList.coordinates.Clear();

        // Populate the CoordinateList with the new data
        foreach (var building in buildingCoordinates)
        {
            coordinateList.coordinates.Add(building);
            Debug.Log($"Added building: {building.name}, Latitude: {building.latitude}, Longitude: {building.longitude}");
        }

        Debug.Log("CoordinateList populated successfully!");
    }
}


