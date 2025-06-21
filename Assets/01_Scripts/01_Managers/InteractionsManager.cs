using ArthemyDev.ScriptsTools;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class InteractionsManager : SingletonManager<InteractionsManager>
{

    [BoxGroup("Mouse")][SerializeField] private Image mouseIcon;
    [BoxGroup("Mouse")][SerializeField] private Sprite defaultMouse;
    [BoxGroup("Mouse")][SerializeField] private Sprite searchMouse;
    [BoxGroup("Mouse")][SerializeField] private Sprite lookMouse;
    [BoxGroup("Mouse")][SerializeField] private Sprite changeSceneLeftMouse;
    [BoxGroup("Mouse")][SerializeField] private Sprite changeSceneRightMouse;

    [BoxGroup("Clue selection")] [SerializeField] private Clue selectedClue;
    
    public void SelectItem(Clue clue)
    {
        selectedClue = clue;
        mouseIcon.sprite = clue.GetIcon();
    }

    public bool isItemSelected() { return selectedClue != null;}

    public Clue GetSelectedItem()
    {
        return selectedClue;
    }
    
    public void DeselectItem()
    {
        selectedClue = null;
        SetDefaultMouse();
    }

    public void SetDefaultMouse()
    {
        mouseIcon.sprite = defaultMouse;
    }

    public void SetSearchMouse()
    {
        mouseIcon.sprite = searchMouse;
    }

    public void SetLookMouse()
    {
        mouseIcon.sprite = lookMouse;
    }

    public void SetChangeSceneLeftMouse()
    {
        mouseIcon.sprite = changeSceneLeftMouse;
    }
    
    public void SetChangeSceneRightMouse()
    {
        mouseIcon.sprite = changeSceneRightMouse;
    }
    
}
