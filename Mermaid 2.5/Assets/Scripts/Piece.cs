using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField] MirrorInfo pickedPieces;
    [SerializeField] int index;
    public GameObject piece;

    public bool canPickUp = false;

    void Start()
    {
        canPickUp = false;
    }

    void Update()
    {
        if (canPickUp == true && Input.GetKeyDown(KeyCode.E))
        {
            piece.SetActive(false);
            pickedPieces.pickedUpPieces[index] = true;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            canPickUp = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            canPickUp = false;
        }
    }

    private void Awake()
    {
        if (pickedPieces.pickedUpPieces[index])
        {
            Destroy(gameObject);
            return;
        }
    }
}
