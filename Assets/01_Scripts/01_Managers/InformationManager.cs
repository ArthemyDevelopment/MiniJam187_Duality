using System.Collections.Generic;

using ArthemyDev.ScriptsTools;
using UnityEngine;


[DefaultExecutionOrder(-1)]
public class InformationManager : SingletonManager<InformationManager>
{
    public List<Information> InformationList;


    public void AddInformation(Information info)
    {
        if (info == null) return;
        if (InformationList.Contains(info)) return;

        
        for (int i = 0; i < info.BlockedByInfo.Count; i++)
        {
            if (InformationList.Contains(info.BlockedByInfo[i]))
            {
                return;
                break;
            }
        }
        
        NotificationAlert.current.TriggerNotificacionNewInformation();
        
        if (info.OverrideInfo.Count > 0)
        {
            for (int i = 0; i < info.OverrideInfo.Count; i++)
            {
                RemoveInformation(info.OverrideInfo[i]);
            }

        }
        InformationList.Add(info);
    }

    public void RemoveInformation(Information info)
    {
        InformationList.Remove(info);
    }
}
