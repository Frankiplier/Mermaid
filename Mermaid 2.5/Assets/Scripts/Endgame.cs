using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite withoutKeySprite;

    public Animator playerAnimation;

    public bool canPickUp = false;
    public bool canEnd = false;

    void Start()
    {
        StartCoroutine(LoadAnimation());
    }

    void Update()
    {
        if (canPickUp == true && Input.GetKeyDown(KeyCode.E))
        {
            canEnd = true;
            spriteRenderer.sprite = withoutKeySprite;
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

    IEnumerator LoadAnimation()
    {
        yield return new WaitForSeconds(6f);

        playerAnimation.Play("Dead");
    }
}
