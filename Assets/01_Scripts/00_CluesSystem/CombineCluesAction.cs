using Sirenix.OdinInspector;
using UnityEngine;

public class CombineCluesAction : BaseAction
{

    [BoxGroup("CombineCluesProperties")][SerializeField] private Clue firstSelected;
    [BoxGroup("CombineCluesProperties")][SerializeField] private Clue secondSelected;
    
    
    public override void TriggerAction()
    {
        base.TriggerAction();
        
    }

    public void SetFirstClue(Clue item) { firstSelected = item; }
    public void SetSecondClue(Clue item) { secondSelected = item; }

    public void ResetClues() { firstSelected = null; secondSelected = null; }
    
    public Clue GetFirstClue() {return firstSelected;}
    public Clue GetSecondClue() {return secondSelected;}

    public Clue CluesCombination()
    {
        TriggerAction();
        if (firstSelected == null || secondSelected == null) return null;

        Clue combination = firstSelected.GetCombination(secondSelected);
        
        return combination;
    }
}
