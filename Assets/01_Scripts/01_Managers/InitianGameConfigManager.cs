using System;
using System.Collections.Generic;
using UnityEngine;

public class InitianGameConfigManager : MonoBehaviour
{
    public ChangeLocationAction StartLocation;
    public List<Clue> StartingItems;
    public List<Information> StartingInfo;

    private void Awake()
    {
         StartLocation.TPCamera();
         foreach (var clue in StartingItems)
         {
            InventoryManager.current.StoreClue(clue);    
         }

         foreach (var info in StartingInfo)
         {
             InformationManager.current.AddInformation(info);
         }
         
    }
}
