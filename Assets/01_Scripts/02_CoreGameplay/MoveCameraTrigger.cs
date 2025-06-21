using System;
using UnityEngine;

public class MoveCameraTrigger : MonoBehaviour
{
    [SerializeField] private float moveVelocity;
    
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Mouse"))
        {
            Camera.main.transform.Translate(moveVelocity,0,0);
        }
    }
}
