using Sirenix.OdinInspector;
using UnityEngine;


public class DebugInventory : MonoBehaviour
{
    public Clue testClue;
    public Clue testClue2;
    public SolutionClue Weapon;
    public SolutionClue Motive;
    public SolutionClue KeyEvidence;
    public SolutionClue Weapon2;
    public SolutionClue Motive2;
    public SolutionClue KeyEvidence2;
    

    [Button]
    public void AddClue1()
    {
        InventoryManager.current.StoreClue(testClue);
    }
    [Button]
    public void RemoveClue1()
    {
        InventoryManager.current.RemoveClue(testClue);
    }

    [Button]
    public void AddClue2()
    {
        InventoryManager.current.StoreClue(testClue2);
    }
    [Button]
    public void RemoveClue2()
    {
        InventoryManager.current.RemoveClue(testClue2);
    }

    [Button]
    public void AddWeapon()
    {
        InventoryManager.current.StoreClue(Weapon);
    }
    [Button]
    public void AddMotive()
    {
        InventoryManager.current.StoreClue(Motive);
    }
    [Button]
    public void AddKeyEvidence()
    {
        InventoryManager.current.StoreClue(KeyEvidence);
    }  
    [Button]
    public void AddWeapon2()
    {
        InventoryManager.current.StoreClue(Weapon2);
    }
    [Button]
    public void AddMotive2()
    {
        InventoryManager.current.StoreClue(Motive2);
    }
    [Button]
    public void AddKeyEvidence2()
    {
        InventoryManager.current.StoreClue(KeyEvidence2);
    }

    [Button]
    public void Spend_1Energy()
    {
        EnergyManager.current.SpendEnergy(1);
    }
    [Button]
    public void Spend_10Energy()
    {
        EnergyManager.current.SpendEnergy(10);
    }
    [Button]
    public void Spend_20Energy()
    {
        EnergyManager.current.SpendEnergy(20);
    }
    
    
    
}
