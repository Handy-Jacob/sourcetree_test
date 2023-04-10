using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake test");
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
        
    }
}
