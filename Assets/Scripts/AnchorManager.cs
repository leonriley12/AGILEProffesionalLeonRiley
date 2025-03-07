using UnityEngine;
using Google.XR.ARCoreExtensions;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class ARCoreAnchorManager : MonoBehaviour
{
    public ARAnchorManager anchorManager; // Reference to ARAnchorManager
    public ARSession session;            // Reference to ARSession
    public GameObject markerPrefab;      // Prefab for visualizing anchors
    public CoordinateList coordinateList; // List of coordinates
    public Canvas infoCanvas;            // Reference to the UI Canvas for displaying info
    public Text infoText;


    private void Start()
    {
        // Ensure ARCore Extensions and ARAnchorManager are properly configured
        if (anchorManager == null)
        {
            Debug.LogError("ARAnchorManager is not assigned. Ensure it's added to the scene.");
            return;
        }

        if (session == null)
        {
            Debug.LogError("ARSession is not assigned. Ensure it's added to the scene.");
            return;
        }

        // Loop through all coordinates and place geospatial anchors
        foreach (CoordinateData coordinate in coordinateList.coordinates)
        {
            PlaceGeospatialAnchor(coordinate);
        }
    }

    private void PlaceGeospatialAnchor(CoordinateData coordinate)
    {
        if (ARSession.state != ARSessionState.SessionTracking)
        {
            Debug.LogError("AR session is not tracking.");
            return;
        }

        Quaternion rotation = Quaternion.identity;
        ARGeospatialAnchor geospatialAnchor = anchorManager.AddAnchor(
            coordinate.latitude,
            coordinate.longitude,

            0, // Altitude
            rotation);

        if (geospatialAnchor != null)
        {
            GameObject marker = Instantiate(markerPrefab, geospatialAnchor.transform.position, geospatialAnchor.transform.rotation);
            marker.name = coordinate.name;

            ArrowGuide arrowGuide = Object.FindFirstObjectByType<ArrowGuide>();

            // Add and configure the MarkerInteraction script
            MarkerInteraction interaction = marker.AddComponent<MarkerInteraction>();
            interaction.Setup(infoCanvas, infoText, arrowGuide, $"{coordinate.name}\nLat: {coordinate.latitude}\nLon: {coordinate.longitude}");


            Debug.Log($"Geospatial Anchor placed for {coordinate.name}");
        }
        else
        {
            Debug.LogError($"Failed to create geospatial anchor for {coordinate.name}");
        }
    }
}


