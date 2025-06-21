using UnityEngine;

[CreateAssetMenu(fileName = "NewSolutionClue", menuName = "CustomSO/SolutionClue", order = 0)]
public class SolutionClue : Clue
{
    public SolutionTypes type;

}

public enum SolutionTypes
{
    WEAPON,
    MOTIVE,
    KEYEVIDENCE,
}
