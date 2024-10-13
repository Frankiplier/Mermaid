using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
    [SerializeField] public KeyRoom2 keyRoom2;
    [SerializeField] ChestKey1 picture;
    public AudioSource open;
    public bool canOpen = false;

    [SerializeField] MirrorInfo pickedPieces;
    [SerializeField] int index;
    public bool canPickUp = false;

    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;


    void Update()
    {
        if (canOpen == true && Input.GetKeyDown(KeyCode.E) && picture.chestKey1 == true)
        {
            open.Play();
            canOpen = false;

            spriteRenderer.sprite = openSprite;
            keyRoom2.haveKey2 = true;
            pickedPieces.pickedUpPieces[index] = true;
            
            GetComponent<CapsuleCollider>().enabled = false;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            canOpen = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            canOpen = false;
        }
    }
}
