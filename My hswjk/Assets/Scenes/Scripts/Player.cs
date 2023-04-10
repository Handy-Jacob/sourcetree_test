using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum OffDay
    {
        Mon,
        Tue,
        Wed // alpha
    }

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

    void Update()
    {
        //Debug.Log("Update");
        transform.Rotate(new Vector3(10, 20, 11) * Time.deltaTime * speed);
    }
}
