using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class CareTakerDiaryFirst : MonoBehaviour
{

    [BoxGroup("InfoToShow")][SerializeField] private List<Information> InfoShowCaretakerFirst;
    [BoxGroup("InfoToShow")][SerializeField] private List<Information> InfoShowOthersFirst;
    
    [BoxGroup("Events")][SerializeField] private UnityEvent OnFirst;
    [BoxGroup("Events")][SerializeField] private UnityEvent OnOther;
    
    
    
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
            OnOther.Invoke();
        }
        else
        {
            for (int i = 0; i < InfoShowCaretakerFirst.Count; i++)
            {
                InformationManager.current.AddInformation(InfoShowCaretakerFirst[i]);
            }
            OnFirst.Invoke();
        }
    }
}
