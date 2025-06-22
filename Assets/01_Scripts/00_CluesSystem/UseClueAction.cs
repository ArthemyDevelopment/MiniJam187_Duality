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
            Debug.Log("Check clue aready used");
            InteractionsManager.current.DeselectItem();
            //Dialog
            return;
        }
        if(InteractionsManager.current.GetSelectedItem() == requiredClue)
        { 
            Debug.Log("Check clue correct Required");
            if(!requiredClue.IsReusable()) InventoryManager.current.RemoveClue(requiredClue);
            OnUse.Invoke();
            isUsed = true;
        }
        InteractionsManager.current.DeselectItem();
        
    }
}
