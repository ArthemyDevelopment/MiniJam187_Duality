using UnityEngine;

public class GiveInformation : MonoBehaviour
{
    [SerializeField] private Information infoToGive;

    public void giveInfo()
    {
        InformationManager.current.AddInformation(infoToGive);
    }
}
