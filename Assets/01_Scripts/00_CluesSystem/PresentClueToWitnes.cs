using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.Events;

public class PresentClueToWitnes : BaseAction
{

    [BoxGroup("PresentClueToWitness")][OdinSerialize]private Dictionary<Clue, WitnesInformation> GetInfo;

    [BoxGroup("PresentClueToWitness")][SerializeField] private UnityEvent OnNoInteraction;

    private bool isUsed;
    
    public override void TriggerAction()
    {
        if (InteractionsManager.current.GetSelectedItem() == null) return;
        base.TriggerAction();
        CheckClue();
    }

    private void CheckClue()
    {

        Clue temp = InteractionsManager.current.GetSelectedItem();
        if (temp == null) return;
        if(GetInfo.ContainsKey(temp))
        {
            for (int i = 0; i < GetInfo[temp].InfoToGive.Count; i++)
            {
                InformationManager.current.AddInformation(GetInfo[temp].InfoToGive[i]);
            }
            GetInfo[temp].OnUse.Invoke();
            
        }
        else
        {
            OnNoInteraction.Invoke();
        }
        InteractionsManager.current.DeselectItem();
        
    }
}

//Can't fix typo cause reset the values in inspector.
[Serializable]
public struct WitnesInformation
{
    public List<Information> InfoToGive;
    public UnityEvent OnUse;
}
