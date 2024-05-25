using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    private Button[] LevelButtons;
    
    void Start()
    {
        LevelButtons = this.GetComponentsInChildren<Button>();
        AddListenersToAllButtons();
    }

    private void AddListenersToAllButtons()
    {
        foreach (Button button in LevelButtons)
        {
            button.onClick.AddListener(() => LoadLevel(button.GetComponentInChildren<Text>().text));
        }
    }

    private void LoadLevel(string levelName) 
    {
        switch (levelName)
        {
            case "1":
                const string level1 = "Level " + "1";
                SceneManager.LoadScene(level1);
                this.gameObject.SetActive(false);
                break;
            case "2":
                const string level2 = "Level " + "2";
                SceneManager.LoadScene(level2);
                this.transform.parent.gameObject.GetComponent<LevelControl>().levelArray[1] = 1;
                this.gameObject.SetActive(false);
                break;
            case "3":
                const string level3 = "Level " + "3";
                SceneManager.LoadScene(level3);
                this.transform.parent.gameObject.GetComponent<LevelControl>().levelArray[2] = 1;
                this.gameObject.SetActive(false);
                break;
            case "4":
                const string level4 = "Level " + "4";
                SceneManager.LoadScene(level4);
                this.transform.parent.gameObject.GetComponent<LevelControl>().levelArray[3] = 1;
                this.gameObject.SetActive(false);
                break;
            default:
                break;
        }
    }
}
