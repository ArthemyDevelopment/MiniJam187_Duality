using UnityEngine;

public class CombineCluesAction : BaseAction
{

    public Clue firstSelected;
    public Clue secondSelected;
    
    
    public override void TriggerAction()
    {
        base.TriggerAction();
        
    }

    public Clue CluesCombination()
    {
        TriggerAction();
        if (firstSelected == null || secondSelected == null) return null;

        Clue combination = firstSelected.GetCombination(secondSelected);
        
        return combination;
    }
}
