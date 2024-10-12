using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MirrorInfo", menuName = "Mirror")]

public class MirrorInfo : ScriptableObject
{
    public List<bool> pickedUpPieces = new List<bool>();

    public void ResetList()
    {
        for (int i = 0; i < pickedUpPieces.Count; i++)
            pickedUpPieces[i] = false;
    }
}
