using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basilisk : MonoBehaviour
{
    [SerializeField] Hide hide;
    private float targetTime;
    public bool mustHide;

    public AudioSource danger;

    void Start()
    {
        targetTime = Random.Range(5, 10);
        mustHide = false;
    }

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0)
        {
            StartCoroutine(Jumpscare());

            targetTime = Random.Range(12, 20);
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
        yield return new WaitForSeconds(5);

        Debug.Log("Music stops");

        hide.isHiding = false;
        mustHide = false;
    }
}
