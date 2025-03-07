using UnityEngine;
using UnityEngine.UI;

public class ARCameraToggle : MonoBehaviour

{
    public Canvas FindLocationMenu;
    public GameObject arCamera; // The AR Camera GameObject
    public Button toggleButton; // The button to trigger the toggle

    public void ToggleCamAndCanvases()
    {
        FindLocationMenu.enabled = false;
        // Enable the AR camera
        arCamera.SetActive(true);

    }
}
