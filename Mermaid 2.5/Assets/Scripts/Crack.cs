using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;
    public GameObject chestKey2;
    
    public bool canOpen = false;

    void Start()
    {
        chestKey2.SetActive(false);
    }


    void Update()
    {
        if (canOpen == true && Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.sprite = openSprite;
            chestKey2.SetActive(true);
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
