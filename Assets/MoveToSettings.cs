using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas settingsCanvas;

    public void ToggleCanvases()
    {
        mainMenuCanvas.enabled = !mainMenuCanvas.enabled;
        settingsCanvas.enabled = !settingsCanvas.enabled;
    }
}

