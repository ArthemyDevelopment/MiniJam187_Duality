using Sirenix.OdinInspector;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InfoTextController : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private GameObject AlertHighlight;
    private bool HighlightTurnOff;

    [SerializeField] private TMP_Text textInfo;
    [SerializeField] private bool HasIcon;
    [HideIf("@this.HasIcon==false")][SerializeField] private Image Icon;


    public void SetInfo(string text, Sprite icon)
    {
        textInfo.text = text;
        if(Icon!=null)Icon.sprite = icon;
    }
    
    void Start()
    {
        AlertHighlight.SetActive(true);    
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!HighlightTurnOff)
        {
            AlertHighlight.SetActive(false);
            HighlightTurnOff = true;
        }
    }
}
