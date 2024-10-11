using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3 : MonoBehaviour
{
    public string sceneName;
    [SerializeField] GameObject icon;
    private bool isVisible;

    public void Start()
    {
        icon.SetActive(false);
        isVisible = false;
    }

    public void Update()
    {
        if (isVisible == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    void OnTriggerEnter (Collider player)
    {
        icon.SetActive(true);
        isVisible = true;    
    }

    void OnTriggerExit (Collider player)
    {
        icon.SetActive(false);
        isVisible = false;
    }
}
