using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambient : MonoBehaviour
{
    [SerializeField] Basilisk sound;
    public AudioSource ambient;

    // Start is called before the first frame update
    void Start()
    {
        ambient.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (sound.isDead == true)
        {
            ambient.Stop();
        }
    }
}
