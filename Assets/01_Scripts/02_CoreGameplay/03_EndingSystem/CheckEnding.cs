using UnityEngine;

public class CheckEnding : MonoBehaviour
{
    public NotebookSolveCrimeController SolveCrimeController;
    public SolutionClue CorrectMotive;
    public SolutionClue CorrectWeapon;
    public SolutionClue CorrectOportunity;


    public void DefineEnding()
    {
        if (SolveCrimeController.MotiveSolutionClue == CorrectMotive &&
            SolveCrimeController.WeaponSolutionClue == CorrectWeapon &&
            SolveCrimeController.KeyEvidenceSolutionClue == CorrectOportunity)
        {
            if (EnergyManager.current.IsSolutionOnTime())
            {
                TransitionsManager.current.ChangeScene("GoodEnding");
            }
            else
            {
                TransitionsManager.current.ChangeScene("NeutralEnding");
            }
        }
        else
        {
            TransitionsManager.current.ChangeScene("BadEnding");
        }
    }


}
