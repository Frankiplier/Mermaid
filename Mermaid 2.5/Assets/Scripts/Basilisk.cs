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
    public AudioSource gameplay;
    public AudioSource exit;

    void Start()
    {
        gameplay.volume = 0.3f;

        targetTime = Random.Range(20, 40);
        mustHide = false;

        basilisk.SetActive(false);
    }

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0)
        {
            StartCoroutine(Jumpscare());

            targetTime = Random.Range(30, 60);
        }

        else if (hide.isHiding == true)
        {
            StopCoroutine(Jumpscare());
            danger.Stop();
            StartCoroutine(Hide());
        }

        else if (hide.isHiding == false)
        {
            basilisk.SetActive(false);
        }
    }

    IEnumerator Jumpscare()
    {
        danger.Play();
        gameplay.volume = 0.1f;

        mustHide = true;

        yield return new WaitForSeconds(10);

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
        gameplay.volume = 0f;

        PauseMenu.canPause = false;
        basilisk.SetActive(true);
        eyes.Play("Eyes");

        yield return new WaitForSeconds(5);
        hide.isHiding = false;
        mustHide = false;
        PauseMenu.canPause = true;

        //exit.Play();
        gameplay.volume = 0.3f;
    }
}
