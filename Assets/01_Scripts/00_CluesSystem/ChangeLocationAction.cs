using UnityEngine;

public class ChangeLocationAction : BaseAction
{
    public Transform LocationTarget;
    
    
    public override void TriggerAction()
    {
        base.TriggerAction();
        Camera.main.transform.position = LocationTarget.position;
    }
}
