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
    [SerializeField] Animator transitionAnim;

    void Start()
    {
        isSwitching = false;
    }

    void Update()
    {
        if (isSwitching == true)
        {
            StartCoroutine(LoadLevel());
        }
    }

    void OnTriggerEnter (Collider player)
    {
        isSwitching = true;
    }

    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("End");

        yield return new WaitForSeconds(0.5f);

        sceneInfo.isNextScene = isNextScene;
        SceneManager.LoadScene(sceneName);
    }
}
