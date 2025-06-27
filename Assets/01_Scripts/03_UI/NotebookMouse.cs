using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NotebookMouse : MonoBehaviour
{

    [SerializeField] private Image Icon;
    [SerializeField] private Sprite Default;

    [SerializeField] private CombineSlot CombinationSlotHover;
    [SerializeField] private SolutionSlot SolutionSlotHover;
    
    public CombineSlot GetCombineSlotHover() {return CombinationSlotHover;}
    public SolutionSlot GetSolutionSlotHover(){return SolutionSlotHover;}
    
    private void OnEnable()
    {
        //Icon.raycastTarget = false;
    }

    public void DragClue(Sprite sprite)
    {
        SetMouseIcon(sprite);

    }

    public void DropClue()
    {
        SetMouseIcon(Default);
    }
    
    private void SetMouseIcon(Sprite sprite)
    {
        Icon.sprite = sprite;
    }
    
    void Update()
    {
        transform.position = Input.mousePosition;
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("NotebookInventoryCombineSlot_1")) CombinationSlotHover= CombineSlot.SLOT1;
        else if (other.CompareTag("NotebookInventoryCombineSlot_2")) CombinationSlotHover= CombineSlot.SLOT2;
        else if (other.CompareTag("NotebookSolutionWeapon")) SolutionSlotHover= SolutionSlot.WEAPON;
        else if (other.CompareTag("NotebookSolutionMotive")) SolutionSlotHover= SolutionSlot.MOTIVE;
        else if (other.CompareTag("NotebookSolutionKeyEvidence")) SolutionSlotHover= SolutionSlot.OPORTUNITY;
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("NotebookInventoryCombineSlot_1")) CombinationSlotHover= CombineSlot.NULL;
        else if (other.CompareTag("NotebookInventoryCombineSlot_2")) CombinationSlotHover= CombineSlot.NULL;
        else if (other.CompareTag("NotebookSolutionWeapon")) SolutionSlotHover= SolutionSlot.NULL;
        else if (other.CompareTag("NotebookSolutionMotive")) SolutionSlotHover= SolutionSlot.NULL;
        else if (other.CompareTag("NotebookSolutionKeyEvidence")) SolutionSlotHover= SolutionSlot.NULL;
    }
}

public enum CombineSlot
{
    NULL,
    SLOT1,
    SLOT2,
}

public enum SolutionSlot
{
    NULL,
    MOTIVE,
    WEAPON,
    OPORTUNITY
}
