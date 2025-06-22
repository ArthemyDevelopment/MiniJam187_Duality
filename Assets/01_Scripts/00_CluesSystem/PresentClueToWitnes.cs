using System;
using System.Collections.Generic;
using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.Events;

public class PresentClueToWitnes : BaseAction
{

    [OdinSerialize]private Dictionary<Clue, WitnesInformation> GetInfo;

    private bool isUsed;
    
    public override void TriggerAction()
    {
        base.TriggerAction();
        CheckClue();
    }

    private void CheckClue()
    {

        Clue temp = InteractionsManager.current.GetSelectedItem();
        if(GetInfo.ContainsKey(temp))
        {
            for (int i = 0; i < GetInfo[temp].InfoToGive.Count; i++)
            {
                InformationManager.current.AddInformation(GetInfo[temp].InfoToGive[i]);
                GetInfo[temp].OnUse.Invoke();
            }
            
        }
        InteractionsManager.current.DeselectItem();
        
    }
}

[Serializable]
public struct WitnesInformation
{
    public List<Information> InfoToGive;
    public UnityEvent OnUse;
}
