using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NotebookMouse : MonoBehaviour
{

    [SerializeField] private Image Icon;
    [SerializeField] private Sprite Default;
    
    public bool OnCombineSlot_1;
    public bool OnCombineSlot_2;

    public bool OnWeaponSolutionSlot;
    public bool OnMotiveSolutionSlot;
    public bool OnKeyEvidenceSolutionSlot;


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
        if (other.CompareTag("NotebookInventoryCombineSlot_1")) OnCombineSlot_1=true;
        else if (other.CompareTag("NotebookInventoryCombineSlot_2")) OnCombineSlot_2=true;
        else if (other.CompareTag("NotebookSolutionWeapon")) OnWeaponSolutionSlot = true;
        else if (other.CompareTag("NotebookSolutionMotive")) OnMotiveSolutionSlot = true;
        else if (other.CompareTag("NotebookSolutionKeyEvidence")) OnKeyEvidenceSolutionSlot = true;
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("NotebookInventoryCombineSlot_1")) OnCombineSlot_1=false;
        else if (other.CompareTag("NotebookInventoryCombineSlot_2")) OnCombineSlot_2=false;
        else if (other.CompareTag("NotebookSolutionWeapon")) OnWeaponSolutionSlot = false;
        else if (other.CompareTag("NotebookSolutionMotive")) OnMotiveSolutionSlot = false;
        else if (other.CompareTag("NotebookSolutionKeyEvidence")) OnKeyEvidenceSolutionSlot = false;
    }
}
