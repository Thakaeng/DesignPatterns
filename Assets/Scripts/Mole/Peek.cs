using UnityEngine;

public class Peek : MonoBehaviour
{
    public float peekSpeed = 1f;
    
    private int moveDirection = 1;
    private bool isPeeking = true;

    private Vector3 originalPosition;

    public MolePool molePoolRef;

    private void Start()
    {
        InitiatePeek();
    }

    private void Update()
    {
        if(isPeeking)
        {
            transform.Translate(Vector3.up * peekSpeed * moveDirection * Time.deltaTime);
        }

        if(transform.position.y >= originalPosition.y + 0.5f)
        {
            moveDirection = -1;
        }

        if(transform.position.y < originalPosition.y)
        {
            PeekEnded();
        }
    }

    public void InitiatePeek()
    {
        originalPosition = transform.position;
        moveDirection = 1;
        isPeeking = true;
    }

    private void PeekEnded()
    {
        isPeeking = false;
        molePoolRef.ReturnToPool(gameObject);
    }
}
