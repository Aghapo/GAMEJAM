using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour
{
    public Button FullscreenButton;
    private bool isFullscreen = false;
   public void SetFullscreen(bool isFullscreen)
   {
        isFullscreen = !isFullscreen;
        Screen.fullScreen = isFullscreen;

        UpdateButtonText();
   }
    public void UpdateButtonText()
    {
        Text buttonText = FullscreenButton.GetComponentInChildren<Text>();
        if (buttonText != null) {
            buttonText.text = isFullscreen ? "Cýkýs Tam Ekran" : "Tam Ekran Ac";
        }
    }
}
