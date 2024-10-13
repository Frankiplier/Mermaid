using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject credits;
    bool creditsEnabled;
    public string sceneName;

    public void Start()
    {
        credits.SetActive(false);
        creditsEnabled = false;
        
        //gameObject.GetComponent<Button>().onClick.AddListener(Credits);
    }

    public void PlayGame()
    {
        StartCoroutine(StartSound());
    }

    public void Credits()
    {
        creditsEnabled ^= true;
        credits.SetActive(creditsEnabled);
    }

    public void QuitGame()
    {
        StartCoroutine(ExitSound());
    }

    IEnumerator StartSound()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator ExitSound()
    {
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }
}
