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
            if (clue.ClueGiveInformation()) InformationManager.current.AddInformation(clue.GetInformation());
            InventorySlots[i].StoreClue(clue);
            CluesInInventory.Add(clue);
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
