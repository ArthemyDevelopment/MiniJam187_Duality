using System;
using System.Collections.Generic;
using ArthemyDev.ScriptsTools;
using NUnit.Framework;
using TMPro;
using UnityEngine;

public class NotebookInformationController : MonoBehaviour
{

    [SerializeField] private GameObject TextTemplate;
    [SerializeField] private GameObject SuspectTemplate;
    [SerializeField] private float TextTemplateSize;
    [SerializeField] private float SuspectsTemplateSize;
    [SerializeField] private float PadingSize;
    [SerializeField] private RectTransform SuspectParent;
    //[SerializeField] private List<Information> SusInfo;
    [SerializeField] private RectTransform LeadsParent;
    //[SerializeField] private List<Information> LeadsInfo;
    [SerializeField] private RectTransform FactsParent;
    //[SerializeField] private List<Information> FactsInfo;

    [SerializeField] private Dictionary<Information, GameObject> PrevInfo = new Dictionary<Information, GameObject>();


    private void OnEnable()
    {
        OrganizeInformation(); 
    }

    public void OrganizeInformation()
    {
        /*SusInfo = new List<Information>();
        LeadsInfo = new List<Information>();
        FactsInfo = new List<Information>();*/
        
        /*ScriptsTools.DestroyAllChildrens(SuspectParent);
        ScriptsTools.DestroyAllChildrens(LeadsParent);
        ScriptsTools.DestroyAllChildrens(FactsParent);*/

        List<Information> infoToRemove= new List<Information>();
        
        foreach (var key in PrevInfo.Keys)
        {
            if (!InformationManager.current.InformationList.Contains(key))
            {
                Destroy(PrevInfo[key]);
                infoToRemove.Add(key);
               
            }
        }

        foreach (var key in infoToRemove)
        {
            PrevInfo.Remove(key);
        }

        for (int i = 0; i < InformationManager.current.InformationList.Count; i++)
        {
            if(PrevInfo.ContainsKey(InformationManager.current.InformationList[i])) continue;
            
            switch (InformationManager.current.InformationList[i].type)
            {
                case InfoTypes.SUSPECTS:
                    SetUpNewInfo(SuspectTemplate,InformationManager.current.InformationList[i],SuspectParent);
                    break;
                case InfoTypes.LEADS:
                    SetUpNewInfo(TextTemplate,InformationManager.current.InformationList[i],LeadsParent);
                    break;
                case InfoTypes.FACTS:
                    SetUpNewInfo(TextTemplate,InformationManager.current.InformationList[i],FactsParent);
                    break;
            }
        }
        
        SetContainerHeight(SuspectParent, SuspectsTemplateSize);
        SetContainerHeight(LeadsParent, TextTemplateSize);
        SetContainerHeight(FactsParent, TextTemplateSize);
        
        
    }

    private void SetUpNewInfo(GameObject template,Information info, RectTransform parent)
    {
        var temp = Instantiate(template, parent).GetComponent<InfoTextController>();
        temp.SetInfo(info.informationText, info.icon);
        temp.gameObject.SetActive(true);
        PrevInfo.Add(info, temp.gameObject);
    }

    private void SetContainerHeight(RectTransform container, float templateSize)
    {
        var newHeight = (container.childCount * templateSize) + (container.childCount * PadingSize);
         
        container.sizeDelta = new Vector2(container.sizeDelta.x, newHeight);
    }

}
