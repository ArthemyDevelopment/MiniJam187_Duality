using Sirenix.OdinInspector;
using UnityEngine;


[CreateAssetMenu(fileName = "NewInformation", menuName = "CustomSO/Information", order = 1)]
public class Information : SerializedScriptableObject
{
    public InfoTypes type;
    public Sprite icon; 
    [TextArea] public string informationText;
    [SerializeField] public Information OverrideInfo;
}

public enum InfoTypes
{
    SUSPECTS,
    LEADS,
    FACTS,
}