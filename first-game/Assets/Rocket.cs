using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] float rust = 10f;
    Rigidbody rigidbody;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        rotate();
    }

    private void rotate()
    {
        rigidbody.freezeRotation = true;
        float force = rust * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * force);
        }


        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.back);
        }

        rigidbody.freezeRotation = false;
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up);
            if (audioSource.isPlaying == false)
            {
                audioSource.Play();
            }
        }
    }
}