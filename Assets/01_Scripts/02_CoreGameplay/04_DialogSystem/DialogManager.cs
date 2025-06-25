using System;
using System.Collections;
using ArthemyDev.ScriptsTools;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject Mouse;
    public GameObject OpenNotebook;

    public GameObject DialogBox;
    public Image DialogChrIcon;
    public TMP_Text DialogTextArea;
    public float delayTextChar;
    private Coroutine ShowTextCoroutine;
    private bool showingText;
    private bool isTextComplete;
    
    public void TriggerDialog(Dialog dialog)
    {
        InitDialogBox(dialog.ChrIcon);
        ShowTextCoroutine = StartCoroutine(ShowText(dialog.DialogText));
    }

    private void InitDialogBox(Sprite sprite)
    {
        showingText = true;
        Mouse.SetActive(false);
        OpenNotebook.SetActive(false);
        DialogChrIcon.sprite = sprite;
        DialogBox.SetActive(true);
    }

    private IEnumerator ShowText(string text)
    {
        isTextComplete = false;
        DialogTextArea.text = text;
        for (int i = 0; i < DialogTextArea.text.Length; i++)
        {
            DialogTextArea.maxVisibleCharacters = i + 1;
            yield return ScriptsTools.GetWait(delayTextChar);
        }

        isTextComplete = true;
    }
    

    private void CloseDialogBox()
    {
        DialogBox.SetActive(false);
        Mouse.SetActive(true);
        OpenNotebook.SetActive(true);
        showingText = false;
    }

    public void Update()
    {
        if (!showingText) return;
        if (Input.GetMouseButtonDown(0))
        {
            if (!isTextComplete)
            {
                isTextComplete = true;
                StopCoroutine(ShowTextCoroutine);
                DialogTextArea.maxVisibleCharacters = DialogTextArea.text.Length + 1;
            }
            else
            {
                CloseDialogBox();    
            }
            
            
        }
        
    }
}
