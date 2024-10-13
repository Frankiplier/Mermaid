using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] Endgame endgame;
    [SerializeField] Animator transitionAnim;
    [SerializeField] public SceneInfo sceneInfo;
    public bool canUnlock = false;
    public string sceneName;
    public bool isNextScene = true;
 
    void Update()
    {
        if (canUnlock == true && endgame.canEnd == true && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(LoadLevel());
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            canUnlock = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            canUnlock = false;
        }
    }

    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("End");

        yield return new WaitForSeconds(0.5f);

        sceneInfo.isNextScene = isNextScene;
        SceneManager.LoadScene(sceneName);
    }
}
