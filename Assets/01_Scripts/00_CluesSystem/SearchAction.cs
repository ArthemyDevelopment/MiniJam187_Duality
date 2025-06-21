using UnityEngine;
using UnityEngine.Events;

public class SearchAction : BaseAction
{
    [SerializeField] private UnityEvent OnSearch;
    
    
    public override void TriggerAction()
    {
        base.TriggerAction();
        OnSearch.Invoke();
    }
}
