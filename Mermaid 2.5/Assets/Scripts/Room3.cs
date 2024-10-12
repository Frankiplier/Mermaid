using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room3 : MonoBehaviour
{
    public string sceneName;
    [SerializeField] Animator transitionAnim;
    [SerializeField] public KeyRoom3 keyRoom3;

    private bool isVisible;

    public void Start()
    {
        isVisible = false;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.E) && isVisible == true && keyRoom3.haveKey3 == true)
        {
            StartCoroutine(LoadLevel());
        }
    }

    void OnTriggerEnter (Collider player)
    {
        isVisible = true;    
    }

    void OnTriggerExit (Collider player)
    {
        isVisible = false;
    }

    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("End");

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(sceneName);
    }
}
