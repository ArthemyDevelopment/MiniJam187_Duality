using UnityEngine;
using UnityEngine.Events;

public class UseClueAction : BaseAction
{
    [SerializeField] private Clue requiredClue;
    [SerializeField] private UnityEvent OnUse;

    private bool isUsed;
    
    public override void TriggerAction()
    {
        base.TriggerAction();
        CheckClue();
    }

    private void CheckClue()
    {
        if (isUsed)
        {
            InteractionsManager.current.DeselectItem();
            //Dialog
            return;
        }
        if(InteractionsManager.current.GetSelectedItem() == requiredClue)
        { 
            InventoryManager.current.RemoveClue(requiredClue);
            OnUse.Invoke();
            isUsed = true;
        }
        InteractionsManager.current.DeselectItem();
        
    }
}
