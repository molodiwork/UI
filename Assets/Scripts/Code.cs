using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code : MonoBehaviour
{

    public Text UiText = null;
    public Text LooseScreen;
    public Text WinScreen;
    public GameObject Button;


    public void CodeFunction(string Numbers)
    {
        if (UiText.text.Length< 2)
        {
            UiText.text = UiText.text + Numbers;
            LooseScreen.text = UiText.text;
            WinScreen.text = UiText.text;
            CheckNumbers();
        }
    }
    private void CheckNumbers()
    {
        if(UiText.text.Length>0)
        {
            Button.SetActive(true);
        }
        else
        {
            Button.SetActive(false);
        }
    }

    public void Delete()
    {
        UiText.text = string.Empty;
        CheckNumbers();
    }

}
