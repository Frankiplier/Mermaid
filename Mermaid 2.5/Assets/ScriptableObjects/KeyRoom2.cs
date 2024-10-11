using UnityEngine;

[CreateAssetMenu(fileName = "KeyRoom2", menuName = "Key2")]

public class KeyRoom2 : ScriptableObject
{
    public bool haveKey2 = false;

    void OnEnable()
    {
        haveKey2 = false;
    }
}
