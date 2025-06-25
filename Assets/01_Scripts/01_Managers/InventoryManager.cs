using System.Collections.Generic;
using ArthemyDev.ScriptsTools;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class InventoryManager : SingletonManager<InventoryManager>
{
    public List<Clue> CluesInInventory;
    public InventorySlotController[] InventorySlots= new InventorySlotController[13];



    public void StoreClue(Clue clue)
    {
        for (int i = 0; i < InventorySlots.Length; i++)
        {
            if(InventorySlots[i].GetClueInSlot()!=null) continue;
            if (clue.ClueGiveInformation())
            {
                if(!clue.ClueMultipleInformation())InformationManager.current.AddInformation(clue.GetInformation());
                else
                {
                    List<Information> temp = clue.GetMultiInformation();
                    for (int j = 0; j < temp.Count; j++)
                    {
                        InformationManager.current.AddInformation(temp[j]);
                    }
                }
            }
            if(clue.GetForceToReplace()) RemoveClue(clue.clueToReplace);
            InventorySlots[i].StoreClue(clue);
            CluesInInventory.Add(clue);
            
            NotificationAlert.current.TriggerNotificationNewClueDescription();
            
            break;
        }
    }

    public void RemoveClue(Clue clue)
    {
        if (CluesInInventory.Contains(clue))
        {
            for (int i = 0; i < InventorySlots.Length; i++)
            {
                if(InventorySlots[i].GetClueInSlot()!=clue) continue;
                InventorySlots[i].RemoveClue();
                CluesInInventory.Remove(clue);
                break;
            }
        }
    }
    
    
    
}
