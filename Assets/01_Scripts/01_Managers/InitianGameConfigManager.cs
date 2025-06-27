using System;
using System.Collections.Generic;
using UnityEngine;

public class InitianGameConfigManager : MonoBehaviour
{
    [SerializeField]private ChangeLocationAction StartLocation;
    [SerializeField]private List<Clue> StartingItems;
    [SerializeField]private List<Information> StartingInfo;

    private void Start()
    {
         StartLocation.HardTPCamera();
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
