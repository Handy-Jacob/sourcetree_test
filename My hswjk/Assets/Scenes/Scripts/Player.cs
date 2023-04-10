using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private void Awake()
    {
        Debug.Log("Awake test");
        Debug.Log("source tree");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable test");
    }

    void Start()
    {
        Debug.Log("Start test");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 20, 11) * Time.deltaTime * speed);
    }
}
