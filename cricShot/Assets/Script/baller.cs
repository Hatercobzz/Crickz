using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class baller : MonoBehaviour
{
    public GameObject ballPrefab;
    public float speed = 5f;
    public float instantiationInterval = 1.0f;
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = 0f;
    public float maxY = 5f;

    void Start()
    {
       // StartCoroutine(InstantiateBallsWithDelay());

    }
    public void InstantiateBall(Vector3 position)
    {
        Instantiate(ballPrefab, position, Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            float randomNum = UnityEngine.Random.Range(1f,2f);
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            ball.transform.Rotate(-25f, 0f, 0f);
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.AddForce(-ball.transform.forward * 1000 * randomNum);
        }
    }
}
