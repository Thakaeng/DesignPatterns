using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SimpleMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    
    private Rigidbody rigidBody;
    private Vector3 targetPosition;

    public Vector3 TargetPosition
    {
        set { targetPosition = value; }
    }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(transform.position + targetPosition * moveSpeed * Time.deltaTime);
    }
}
