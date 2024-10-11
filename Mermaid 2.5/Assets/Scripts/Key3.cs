using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3 : MonoBehaviour
{
    [SerializeField] public KeyRoom3 keyRoom3;

    [SerializeField] GameObject icon;
    public bool isVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        icon.SetActive(false);
        isVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible == true && Input.GetKey(KeyCode.E))
        {
            keyRoom3.haveKey3 = true;

            icon.SetActive(false);
            GetComponent<CapsuleCollider>().enabled = false;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            icon.SetActive(true);
            isVisible = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            icon.SetActive(false);
            isVisible = false;
        }
    }
}
