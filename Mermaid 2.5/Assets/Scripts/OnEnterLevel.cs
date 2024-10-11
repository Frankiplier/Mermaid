using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterLevel : MonoBehaviour
{
    public GameObject entrance;
    public GameObject exit;

    [SerializeField] public SceneInfo sceneInfo;

    public Vector3 offsetEntrance = new Vector3(0, 0, 0);
    public Vector3 offsetExit = new Vector3(0, 0, 0);

    private Rigidbody rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {
        GameObject target = sceneInfo.isNextScene ? entrance : exit;
        Vector3 offset = sceneInfo.isNextScene ? offsetEntrance : offsetExit;

        rb.position = target.transform.position + offset;
    }
}
