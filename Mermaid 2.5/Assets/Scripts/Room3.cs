using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room3 : MonoBehaviour
{
    public string sceneName;
    [SerializeField] Animator transitionAnim;

    [SerializeField] GameObject icon;
    private bool isVisible;
    public bool isSwitching;

    public void Start()
    {
        icon.SetActive(false);
        isVisible = false;
        isSwitching = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isVisible == true && isSwitching == true)
            {
                StartCoroutine(LoadLevel());
            }
        }
    }

    void OnTriggerEnter (Collider player)
    {
        icon.SetActive(true);
        isVisible = true;    
        isSwitching = true;
    }

    void OnTriggerExit (Collider player)
    {
        icon.SetActive(false);
        isVisible = false;
        isSwitching = false;
    }

    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("End");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(sceneName);
    }
}
