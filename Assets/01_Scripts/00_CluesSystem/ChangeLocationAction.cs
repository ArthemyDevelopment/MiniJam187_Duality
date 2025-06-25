using System;
using UnityEngine;

public class ChangeLocationAction : BaseAction
{
    public Transform LocationTarget;
    public GameObject WorldCanvas;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Mouse")) WorldCanvas.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Mouse")) WorldCanvas.SetActive(false);
    }

    public override void TriggerAction()
    {
        base.TriggerAction();
        TPCamera();
    }

    public void TPCamera()
    {
        TransitionsManager.current.TransitionLocation(LocationTarget);
        
    }

    public void HardTPCamera()
    {
        Camera.main.transform.position = LocationTarget.position;
    }
}
