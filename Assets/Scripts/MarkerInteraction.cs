using UnityEngine;
using UnityEngine.UI;

public class MarkerInteraction : MonoBehaviour
{
    public Canvas infoCanvas;          // Reference to the Canvas
    public Text infoText;              // Reference to the text element
    public string infoMessage;         // The message to display for this marker
    private ArrowGuide arrowGuide;  // Reference to the ArrowGuide script

    private bool isPopupVisible = false; // Track if the pop-up is currently visible

    public void Setup(Canvas canvas, Text text, ArrowGuide guide, string message)
    {
        infoCanvas = canvas;
        infoText = text;
        arrowGuide = guide;
        infoMessage = message;
        
    }

    private void OnMouseDown()
    {
        if (infoCanvas != null && infoText != null)
        {
            if (!isPopupVisible)
            {
                // Show the pop-up with the message
                infoText.text = infoMessage;
                infoCanvas.gameObject.SetActive(true);
                isPopupVisible = true;
            }
            else
            {
                // Hide the pop-up
                infoCanvas.gameObject.SetActive(false);
                isPopupVisible = false;
            }
        }

        // Update the arrow's target marker
        if (arrowGuide != null)
        {
            arrowGuide.SetTargetMarker(this.transform); // Set this marker as the new target
            Debug.Log($"Arrow now pointing to: {gameObject.name}");
        }
    }
}

