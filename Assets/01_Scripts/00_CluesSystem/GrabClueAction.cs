using Sirenix.OdinInspector;
using UnityEngine;

public class GrabClueAction : BaseAction
{
    [BoxGroup("GrabClueProperties")][SerializeField] private Clue clue;
    [BoxGroup("GrabClueProperties")][SerializeField] private bool deactivateOnGrab;
    [BoxGroup("GrabClueProperties")][SerializeField] private bool clueGrabed;
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
