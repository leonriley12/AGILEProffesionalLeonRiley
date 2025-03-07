using UnityEngine;
using UnityEngine.UI;

public class MoveToMainMenu : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas settingsCanvas;

    public void ToggleCanvases()
    {
        settingsCanvas.enabled = !settingsCanvas.enabled;
        mainMenuCanvas.enabled = !mainMenuCanvas.enabled;
        
    }
}


