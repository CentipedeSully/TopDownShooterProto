using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Declarations
    [SerializeField] float _moveSpeed = 100;
    [SerializeField] Vector3 _detectedInput = Vector3.zero;
    private Rigidbody _rigidbodyRef;


    //Monobehaviours
    private void Awake()
    {
        _rigidbodyRef = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ReadInputFromKeyboard();
        ApplyForceIfInputDetected();
    }


    //Internal Utils
    private void  ReadInputFromKeyboard()
    {
        _detectedInput.x = Input.GetAxis("Horizontal");
        _detectedInput.z = Input.GetAxis("Vertical");

    }

    private void ApplyForceIfInputDetected()
    {
        if (_detectedInput != Vector3.zero)
            _rigidbodyRef.AddForce(_detectedInput * _moveSpeed * Time.deltaTime);
    }


    //Getters, Setters, & Commands





}
