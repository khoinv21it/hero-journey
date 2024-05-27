using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [SerializeField] GameObject quitPanel;
    public void Exit()
    {
        Application.Quit();
        
    }
    public void OpenAreYouSure()
    {
        quitPanel.SetActive(true);
    }
    public void CloseAreYouSure()
    {
        quitPanel.SetActive(false);
        }
}
    
  