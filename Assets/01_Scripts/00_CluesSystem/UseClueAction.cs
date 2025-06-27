using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class UseClueAction : BaseAction
{
    [BoxGroup("UseClueProperties")][SerializeField] private Clue requiredClue;
    [BoxGroup("UseClueProperties")][SerializeField] private UnityEvent OnUse;

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
            
            if(!requiredClue.IsReusable()) InventoryManager.current.RemoveClue(requiredClue);
            OnUse.Invoke();
            isUsed = true;
        }
        InteractionsManager.current.DeselectItem();
        
    }
}
