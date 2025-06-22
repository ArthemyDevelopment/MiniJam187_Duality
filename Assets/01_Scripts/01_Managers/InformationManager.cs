using System.Collections.Generic;
using System.Linq;
using ArthemyDev.ScriptsTools;
using UnityEngine;

public class InformationManager : SingletonManager<InformationManager>
{
    public List<Information> InformationList;


    public void AddInformation(Information info)
    {
        if (InformationList.Contains(info)) return;

        for (int i = 0; i < info.BlockedByInfo.Count; i++)
        {
            if (InformationList.Contains(info.BlockedByInfo[i]))
            {
                return;
                break;
            }
        }
        
        
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
