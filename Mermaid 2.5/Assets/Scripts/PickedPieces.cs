using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickedPieces : MonoBehaviour
{
    [SerializeField] MirrorInfo pickedPieces;
    [SerializeField] int index;
    public GameObject piece;

    void Start()
    {
        piece.SetActive(false);
    }

    void Update()
    {
        if (pickedPieces.pickedUpPieces[index] == true)
        {
           piece.SetActive(true);
        }
    }
}
