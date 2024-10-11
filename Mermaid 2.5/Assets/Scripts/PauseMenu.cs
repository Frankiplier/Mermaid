using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public SceneInfo sceneInfo;
    [SerializeField] public KeyRoom2 keyRoom2;
    [SerializeField] public KeyRoom3 keyRoom3;

    public GameObject pauseMenu;
    public static bool isPaused;
    public static bool canPause;

    public string sceneName;

    //[SerializeField] AudioSource music;

    void Start()
    {
        Time.timeScale = 1f;

        isPaused = false;
        canPause = true;
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canPause == true)
        {
            if (isPaused == false)
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        //music.Pause();
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        //music.Play();
    }

    public void QuitGame()
    {
        keyRoom2.haveKey2 = false;
        keyRoom3.haveKey3 = false;
        sceneInfo.isNextScene = true;

        SceneManager.LoadScene(sceneName);
    }
}
