using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basilisk : MonoBehaviour
{
    [SerializeField] MirrorInfo pickedPieces;
    [SerializeField] Animator eyes;
    [SerializeField] Hide hide;
    [SerializeField] PauseMenu pauseMenu;
    public GameObject basilisk;
    public GameObject deadMonster;
    private float targetTime;
    public bool mustHide;


    public AudioSource danger;
    public AudioSource gameplay;
    public AudioSource exit;

    public string sceneName;

    void Start()
    {
        gameplay.volume = 0.3f;

        targetTime = Random.Range(10, 15);
        mustHide = false;

        basilisk.SetActive(false);
        deadMonster.SetActive(false);
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

            if ((pickedPieces.pickedUpPieces[0] == true && pickedPieces.pickedUpPieces[1] == true && pickedPieces.pickedUpPieces[2] == true && pickedPieces.pickedUpPieces[3] == true))
            {
                deadMonster.SetActive(true);
                targetTime = 1000;
            }
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

        else if (hide.isHiding == false && mustHide == true)
        {
            Debug.Log("You died");
            SceneManager.LoadScene(sceneName);

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

        gameplay.volume = 0.3f;
    }
}
