using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    public Canvas infoCanvas; // Reference to the Canvas

    public void CloseInfoPanel()
    {
        infoCanvas.gameObject.SetActive(false); // Hides the Canvas
    }
}

