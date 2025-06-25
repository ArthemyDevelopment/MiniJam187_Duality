using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotController : MonoBehaviour
{
    
    [BoxGroup("Default Slot")] [SerializeField] private Image IconImage;
    [BoxGroup("Clue data")][SerializeField] private Clue currentClue;
    [BoxGroup("Clue data")][SerializeField] private ClueData currentClueData;

    


    public bool IsClueInSlot() { return currentClue != null; }


    public void StoreClue(Clue clue)
    {
        if (clue == null)
        {
            RemoveClue();
            return;
        }
        
        IconImage.gameObject.SetActive(true);
        currentClue = clue;
        ClueData data = clue.GetClueInfo();
        currentClueData = data;
        IconImage.sprite = data.clueIcon;
    }

    public Clue GetClueInSlot()
    {
        return currentClue;
    }

    public ClueData GetClueDataInSlot()
    {
        return currentClueData;
    }

    public void RemoveClue()
    {
        IconImage.gameObject.SetActive(false);
        currentClue = null;
        currentClueData = new ClueData();
    }
    
}
