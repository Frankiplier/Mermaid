using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    [SerializeField] Animator playerAnimation;

    public bool canPickUp = false;
    public bool canEnd = false;

    void Start()
    {
        StartCoroutine(LoadAnimation());

        playerAnimation.Play("Keys jingling");
    }

    void Update()
    {
        if (canPickUp == true && Input.GetKeyDown(KeyCode.E))
        {
            canEnd = true;
            playerAnimation.Play("Keys stolen");


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
        yield return new WaitForSeconds(8f);
    }
}
