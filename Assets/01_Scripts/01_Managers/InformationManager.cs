using System.Collections.Generic;
using ArthemyDev.ScriptsTools;
using UnityEngine;

public class InformationManager : SingletonManager<InformationManager>
{
    public List<Information> InformationList;


    public void AddInformation(Information info)
    {
        if (InformationList.Contains(info)) return;
        if(info.OverrideInfo!=null) RemoveInformation(info.OverrideInfo);
        InformationList.Add(info);
    }

    public void RemoveInformation(Information info)
    {
        InformationList.Remove(info);
    }
}
