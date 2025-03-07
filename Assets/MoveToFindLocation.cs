using UnityEngine;
using UnityEngine.UI;

public class MoveToFindLocation : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas FindLocationCanvas;

    public void ToggleCanvases()
    {
        mainMenuCanvas.enabled = !mainMenuCanvas.enabled;
        FindLocationCanvas.enabled = !FindLocationCanvas.enabled;
       
    }
}