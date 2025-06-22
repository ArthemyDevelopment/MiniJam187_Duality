using System.Collections.Generic;
using UnityEngine;

public class CareTakerDiaryFirst : MonoBehaviour
{

    public List<Information> InfoShowCaretakerFirst;
    public List<Information> InfoShowOthersFirst;
    
    private bool DiaryShowToOthers;

    public void SetDiaryShown()
    {
        DiaryShowToOthers = true;
    }

    public void ShowDiaryToCaretaker()
    {
        if (DiaryShowToOthers)
        {
            for (int i = 0; i < InfoShowOthersFirst.Count; i++)
            {
                InformationManager.current.AddInformation(InfoShowOthersFirst[i]);
            }
        }
        else
        {
            for (int i = 0; i < InfoShowCaretakerFirst.Count; i++)
            {
                InformationManager.current.AddInformation(InfoShowCaretakerFirst[i]);
            }
        }
    }
}
