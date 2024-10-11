using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] Animator transitionAnim;

    void Start()
    {
        transitionAnim.SetTrigger("Start");
    }
}
