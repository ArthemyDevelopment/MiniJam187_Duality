using System;
using System.Collections.Generic;
using ArthemyDev.ScriptsTools;
using TMPro;
using UnityEngine;

public class NotebookInformationController : MonoBehaviour
{

    [SerializeField] private GameObject TextTemplate;
    [SerializeField] private RectTransform SuspectParent;
    //[SerializeField] private List<Information> SusInfo;
    [SerializeField] private RectTransform LeadsParent;
    //[SerializeField] private List<Information> LeadsInfo;
    [SerializeField] private RectTransform FactsParent;
    //[SerializeField] private List<Information> FactsInfo;


    private void OnEnable()
    {
        OrganizeInformation(); 
    }

    public void OrganizeInformation()
    {
        /*SusInfo = new List<Information>();
        LeadsInfo = new List<Information>();
        FactsInfo = new List<Information>();*/
        
        ScriptsTools.DestroyAllChildrens(SuspectParent);
        ScriptsTools.DestroyAllChildrens(LeadsParent);
        ScriptsTools.DestroyAllChildrens(FactsParent);

        for (int i = 0; i < InformationManager.current.InformationList.Count; i++)
        {
            switch (InformationManager.current.InformationList[i].type)
            {
                case InfoTypes.SUSPECTS:
                    TMP_Text temp1 = Instantiate(TextTemplate, SuspectParent).GetComponent<TMP_Text>();
                    temp1.text = InformationManager.current.InformationList[i].informationText;
                    temp1.gameObject.SetActive(true);
                    SuspectParent.sizeDelta = new Vector2(SuspectParent.sizeDelta.x, SuspectParent.sizeDelta.y + temp1.rectTransform.sizeDelta.y + 25);
                    
                    break;
                case InfoTypes.LEADS:
                    TMP_Text temp2 = Instantiate(TextTemplate, LeadsParent).GetComponent<TMP_Text>();
                    temp2.text = InformationManager.current.InformationList[i].informationText;
                    temp2.gameObject.SetActive(true);
                    LeadsParent.sizeDelta = new Vector2(LeadsParent.sizeDelta.x, LeadsParent.sizeDelta.y + temp2.rectTransform.sizeDelta.y + 25);
                    
                    break;
                case InfoTypes.FACTS:
                    TMP_Text temp3 = Instantiate(TextTemplate, FactsParent).GetComponent<TMP_Text>();
                    temp3.text = InformationManager.current.InformationList[i].informationText;
                    temp3.gameObject.SetActive(true);
                    FactsParent.sizeDelta = new Vector2(FactsParent.sizeDelta.x, FactsParent.sizeDelta.y + temp3.rectTransform.sizeDelta.y + 25);
                    
                    break;
            }
        }
        
        
    }

}
