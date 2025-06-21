using UnityEngine;

public class GiveClue : MonoBehaviour
{
    [SerializeField] private Clue clueToGive;

    public void giveClue()
    {
        InventoryManager.current.StoreClue(clueToGive);
    }

}
