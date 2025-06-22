using UnityEngine;

public class ChangeLocationAction : BaseAction
{
    public Transform LocationTarget;
    
    
    public override void TriggerAction()
    {
        base.TriggerAction();
        TPCamera();
    }

    public void TPCamera()
    {
        TransitionsManager.current.TransitionLocation(LocationTarget);
        
    }
}
