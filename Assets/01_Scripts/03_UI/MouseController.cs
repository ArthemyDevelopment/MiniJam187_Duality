using System;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    private Action InteractionAction;


    private void Awake()
    {
        Cursor.visible = false;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (HitboxRecognitionSystem.ColliderHaveInteraction(other))
        {
            InteractionAction = HitboxRecognitionSystem.GetInteraction(other);
        }
        
        if (InteractionsManager.current.isItemSelected())return;
        
        if(other.CompareTag("LookInteraction"))
        {
            InteractionsManager.current.SetLookMouse();
        }
        else if(other.CompareTag("SearchInteraction"))
        {
            InteractionsManager.current.SetSearchMouse();
        }
        else if(other.CompareTag("ChangeScreenLeftInteraction"))
        {
            InteractionsManager.current.SetChangeSceneLeftMouse();
        }
        else if(other.CompareTag("ChangeScreenRightInteraction"))
        {
            InteractionsManager.current.SetChangeSceneRightMouse();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (HitboxRecognitionSystem.ColliderHaveInteraction(other))
        {
            InteractionAction = null;
        }

        if (InteractionsManager.current.isItemSelected()) return;
        
        if (other.CompareTag("LookInteraction") ||
            other.CompareTag("SearchInteraction") ||
            other.CompareTag("ChangeScreenLeftInteraction") ||
            other.CompareTag("ChangeScreenRightInteraction"))
        {
            InteractionsManager.current.SetDefaultMouse();
        }
    }


    private void Update()
    {
        /*var screenPoint = Input.mousePosition;
        screenPoint.z = 10.0f; //distance of the plane from the camera
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);*/

        if (Input.GetMouseButtonDown(0)&&InteractionAction!=null)
        {
            InteractionAction.Invoke();
        }
        else if (Input.GetMouseButtonDown(0) && InteractionAction == null)
        {
            InteractionsManager.current.DeselectItem();
        }
        
        
    }

    private void LateUpdate()
    {
        var screenPoint = Input.mousePosition;
        screenPoint.z = 1.0f; //distance of the plane from the camera
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }
}
