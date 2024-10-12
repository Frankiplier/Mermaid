using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;
    
    public bool canOpen = false;
    public bool chestKey = false;


    void Update()
    {
        if (canOpen == true && Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.sprite = openSprite;
            chestKey = true;
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
