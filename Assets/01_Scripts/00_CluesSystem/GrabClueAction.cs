using UnityEngine;

public class GrabClueAction : BaseAction
{
    [SerializeField] private Clue clue;
    [SerializeField] private bool deactivateOnGrab;
    [SerializeField] private bool clueGrabed;
    public bool isClueGrabed() { return clueGrabed; }
    
    public override void TriggerAction()
    {
        if (InteractionsManager.current.isItemSelected())
        {
            InteractionsManager.current.DeselectItem();
            return;
        }
            
        
        base.TriggerAction();
        AddClueToInventory();
    }

    public void AddClueToInventory()
    {
        if (clueGrabed)
        {
            //Dialog
            return;
        }
        InventoryManager.current.StoreClue(clue);
        clueGrabed = true;
        if (deactivateOnGrab) gameObject.SetActive(false);
        else
        {
            InteractionsManager.current.SetLookMouse();
            gameObject.tag = "LookInteraction";
        }
    }

    
}
