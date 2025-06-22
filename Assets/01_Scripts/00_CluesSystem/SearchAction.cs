using UnityEngine;
using UnityEngine.Events;

public class SearchAction : BaseAction
{
    [SerializeField] private bool SingleTrigger;
    [SerializeField] private UnityEvent OnSearch;
    bool alreadyTrigger;
    
    public override void TriggerAction()
    {
        if (SingleTrigger && alreadyTrigger) return;
        base.TriggerAction();
        OnSearch.Invoke();
        alreadyTrigger = true;
    }
}
