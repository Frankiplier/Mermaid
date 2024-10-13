using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        Time.timeScale = 1f;
        StartCoroutine(StartGame());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(10f);

        SceneManager.LoadScene(sceneName);
    }
}
