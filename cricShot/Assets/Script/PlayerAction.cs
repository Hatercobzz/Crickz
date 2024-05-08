using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * verticalInput * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
