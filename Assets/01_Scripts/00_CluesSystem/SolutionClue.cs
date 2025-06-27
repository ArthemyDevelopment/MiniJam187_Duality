using UnityEngine;

[CreateAssetMenu(fileName = "NewSolutionClue", menuName = "CustomSO/SolutionClue", order = 0)]
public class SolutionClue : Clue
{
    [SerializeField]private SolutionTypes type;
    
    public SolutionTypes GetType() {return type;}

}

public enum SolutionTypes
{
    WEAPON,
    MOTIVE,
    OPPORTUNITY,
}
