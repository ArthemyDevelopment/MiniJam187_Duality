using System;
using UnityEngine;

public class MoveCameraTrigger : MonoBehaviour
{
    [SerializeField] private float moveVelocity;
    private bool canMove = true;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Mouse")&&canMove)
        {
            Camera.main.transform.Translate(moveVelocity,0,0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("StopMovementCamera")) canMove = false;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("StopMovementCamera")) canMove = true;
    }
}
