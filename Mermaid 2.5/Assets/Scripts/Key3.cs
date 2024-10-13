using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3 : MonoBehaviour
{
    [SerializeField] public KeyRoom3 keyRoom3;
    [SerializeField] ChestKey2 crack;
    public AudioSource open;
    public bool canOpen = false;

    [SerializeField] MirrorInfo pickedPieces;
    [SerializeField] int index;
    public bool canPickUp = false;

    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;


    void Update()
    {
        if (canOpen == true && Input.GetKeyDown(KeyCode.E) && crack.chestKey2 == true)
        {
            open.Play();
            canOpen = false;

            spriteRenderer.sprite = openSprite;
            keyRoom3.haveKey3 = true;
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
