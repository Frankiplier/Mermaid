using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnExitLevel : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = true;
    public bool isSwitching;


    [SerializeField] public SceneInfo sceneInfo;
    [SerializeField] public KeyRoom2 keyRoom2;
    [SerializeField] Animator transitionAnim;

    void Start()
    {
        isSwitching = false;
    }

    void Update()
    {
        if (isSwitching == true && keyRoom2.haveKey2 == true)
        {
            StartCoroutine(LoadLevel());
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            isSwitching = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            isSwitching = false;
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
