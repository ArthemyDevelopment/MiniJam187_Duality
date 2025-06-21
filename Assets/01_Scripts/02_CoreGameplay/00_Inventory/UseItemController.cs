using System;
using UnityEngine;

public class UseItemController : MonoBehaviour
{
    [SerializeField] private InventorySlotController slotController;
    [SerializeField] private BoxCollider2D _collider;

    private void OnEnable()
    {
        HitboxRecognitionSystem.AddInteractableObject(_collider, SelectItem);
    }


    public void SelectItem()
    {
        InteractionsManager.current.SelectItem(slotController.GetClueInSlot());
    }
    
}
