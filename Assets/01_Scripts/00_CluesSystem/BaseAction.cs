using System;
using Sirenix.OdinInspector;
using UnityEngine;

public class BaseAction : SerializedMonoBehaviour
{
    [SerializeField] private float EnergyCost;
    [SerializeField] private bool hasCollider = true;
    [HideIf("@this.hasCollider == false")][SerializeField] private Collider2D hitbox;


    private void OnEnable()
    {
        if(hitbox!=null) HitboxRecognitionSystem.AddInteractableObject(hitbox, TriggerAction);
    }

    private void OnDisable()
    {
        if(hitbox!=null) HitboxRecognitionSystem.RemoveInteratableObject(hitbox);
    }

    public virtual void TriggerAction()
    {
        EnergyManager.current.SpendEnergy(EnergyCost);
    }
}
