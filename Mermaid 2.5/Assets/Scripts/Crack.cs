using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;
    
    public bool canOpen = false;
    public bool chestKey2 = false;


    void Update()
    {
        if (canOpen == true && Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.sprite = openSprite;
            chestKey2 = true;
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
