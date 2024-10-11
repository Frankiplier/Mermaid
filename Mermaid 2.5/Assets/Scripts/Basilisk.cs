using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basilisk : MonoBehaviour
{
    [SerializeField] Hide hide;
    private float targetTime;

    public AudioSource danger;

    void Start()
    {
        targetTime = Random.Range(5, 10);
    }

    // Update is called once per frame
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

        yield return new WaitForSeconds(5);

        if (hide.isHiding == true)
        {
            StartCoroutine(Hide());
        }

        else if (hide.isHiding == false)
        {
            Debug.Log("You died");
        }
    }

    IEnumerator Hide()
    {
        yield return new WaitForSeconds(5);

        Debug.Log("Music stops");
    }
}
