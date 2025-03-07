using UnityEngine;

public class ArrowHandler : MonoBehaviour
{
    public ARArrowController arrowController; // Reference to the ARArrowController script
    public int buildingIndex; // Index of the building this button corresponds to

    public void OnButtonPress()
    {
        // Call the method to set the target building index
        arrowController.SetTargetBuilding(buildingIndex);
        Debug.Log($"Button pressed! Building index set to: {buildingIndex}");
    }
}



