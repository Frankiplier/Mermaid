using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;
    public GameObject chestKey1;
    
    public bool canOpen = false;
    public bool chestKey = false;


    void Start()
    {
        chestKey1.SetActive(false);
    }

    void Update()
    {
        if (canOpen == true && Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.sprite = openSprite;
            chestKey = true;

            chestKey1.SetActive(true);
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
