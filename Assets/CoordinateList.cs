using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CoordinateList", menuName = "ScriptableObjects/CoordinateList", order = 1)]
public class CoordinateList : ScriptableObject
{
    public List<CoordinateData> coordinates; // List of building coordinates
}
