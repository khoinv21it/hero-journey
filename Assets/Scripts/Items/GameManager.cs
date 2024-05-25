using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int coinAchieved = 0;
    public TextMeshProUGUI coinAchievedTxt;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoins(int amount)
    {
        coinAchieved += amount;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        if (coinAchievedTxt != null)
        {
            coinAchievedTxt.text = coinAchieved.ToString("000");
        }
    }
}
