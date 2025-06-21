using System;
using UnityEngine;

public class NotebookSolveCrimeController : MonoBehaviour
{
    [SerializeField] private SolutionClue WeaponSolutionClue;
    [SerializeField] private InventorySlotController WeaponSlot;
    [SerializeField] private SolutionClue MotiveSolutionClue;
    [SerializeField] private InventorySlotController MotiveSlot;
    [SerializeField] private SolutionClue KeyEvidenceSolutionClue;
    [SerializeField] private InventorySlotController KeyEvidenceSlot;

    [SerializeField] private GameObject SolveCrimeButton;


    private void OnEnable()
    {
        SolveCrimeButton.SetActive(false);
        CheckSolutions();
    }

    public void CheckSolutionWeapon(Clue clue)
    {
        if (clue.GetType() != typeof(SolutionClue)) return;
        if ((clue as SolutionClue).type != SolutionTypes.WEAPON) return;
        
        WeaponSlot.StoreClue(clue);
        
        CheckSolutions();
        
    }
    
    public void CheckSolutionMotive(Clue clue)
    {
        if (clue.GetType() != typeof(SolutionClue)) return;
        if ((clue as SolutionClue).type != SolutionTypes.MOTIVE) return;
        
        MotiveSlot.StoreClue(clue);
        
        CheckSolutions();
        
    }
    
    public void CheckSolutionKeyEvidence(Clue clue)
    {
        if (clue.GetType() != typeof(SolutionClue)) return;
        if ((clue as SolutionClue).type != SolutionTypes.KEYEVIDENCE) return;
        
        KeyEvidenceSlot.StoreClue(clue);
        
        CheckSolutions();
        
    }

    private void CheckSolutions()
    {
        if (WeaponSlot.IsClueInSlot() && MotiveSlot.IsClueInSlot() && KeyEvidenceSlot.IsClueInSlot())
            SolveCrimeButton.SetActive(true);
    }
    
}
