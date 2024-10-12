using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basilisk : MonoBehaviour
{
    [SerializeField] Animator eyes;
    [SerializeField] Hide hide;
    [SerializeField] PauseMenu pauseMenu;
    public GameObject basilisk;
    private float targetTime;
    public bool mustHide;

    public AudioSource danger;

    void Start()
    {
        targetTime = Random.Range(5, 10);
        mustHide = false;

        basilisk.SetActive(false);
    }

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0)
        {
            StartCoroutine(Jumpscare());

            targetTime = Random.Range(12, 20);
        }

        else if (hide.isHiding == true)
        {
            StopCoroutine(Jumpscare());
            StartCoroutine(Hide());
        }

        else if (hide.isHiding == false)
        {
            basilisk.SetActive(false);
        }
    }

    IEnumerator Jumpscare()
    {
        Debug.Log("Music starts playing");

        mustHide = true;

        yield return new WaitForSeconds(5);

        if (hide.isHiding == true)
        {
            StartCoroutine(Hide());
        }

        else if (hide.isHiding == false)
        {
            Debug.Log("You died");

            mustHide = false;
        }
        
    }

    IEnumerator Hide()
    {
        PauseMenu.canPause = false;
        basilisk.SetActive(true);
        eyes.Play("Eyes");

        yield return new WaitForSeconds(5);
        hide.isHiding = false;
        mustHide = false;
        PauseMenu.canPause = true;
    }
}
