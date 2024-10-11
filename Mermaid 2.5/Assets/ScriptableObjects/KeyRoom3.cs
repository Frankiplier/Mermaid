using UnityEngine;

[CreateAssetMenu(fileName = "KeyRoom3", menuName = "Key3")]

public class KeyRoom3 : ScriptableObject
{
    public bool haveKey3 = false;

    void OnEnable()
    {
        haveKey3 = false;
    }
}
