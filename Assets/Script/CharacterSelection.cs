using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] Player;
    [SerializeField]
    private GameObject selectionPanel;
    [SerializeField]
    private GameObject mainMenuPanel;

    [SerializeField] private GameObject[] Buy;
    [SerializeField] private GameObject[] Continue;

    [SerializeField] private GameObject ThankYouPanel;
    [SerializeField] private GameObject NotEnoughPanel;

    [SerializeField] private Image InsSufficientFundPlayer;
    [SerializeField] private Image ThankYouPlayer;

    [SerializeField] private Sprite[] PlayersImage;
    [SerializeField] private TextMeshProUGUI MoneyRequired;

    [SerializeField] private int[] mrp;

    [SerializeField] private GameObject ScorePanel;
    [SerializeField] private GameObject CoinPanel;
    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<mrp.Length;i++)
        {
           if( PlayerPrefs.GetInt($"Character{i}Brought") ==1)
            {
                TurnOffBuy(i);
            }
        }
    }

    public void TurnOffBuy(int a)
    {
        Buy[a].SetActive(false);
        Continue[a].SetActive(true);
    }
    public void BuyIt(int p)
    {
        if (PlayerPrefs.GetInt("Coin") >= mrp[p])
        {
            PlayerPrefs.SetInt($"Character{p}Brought", 1);
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") - mrp[p]);
            ThankYouForPurchase(p);
        }
        else
        {
            InSufficientFund(p);
        }

    }
    public void ThankYouForPurchase(int p)
    {
        ThankYouPlayer.sprite = PlayersImage[p];
        ThankYouPanel.SetActive(true);
    }
    public void InSufficientFund(int p)
    {
        InsSufficientFundPlayer.sprite = PlayersImage[p];
        int a = mrp[p] - PlayerPrefs.GetInt("Coin");
        MoneyRequired.text = $"<sprite=1>{a}:<br>coins are Needed".ToString();
        NotEnoughPanel.SetActive(true);
    }
    public void CloseALL()
    {
        for(int i=0;i<Player.Length;i++)
        {
            Player[i].SetActive(false);
        }
    }
    public void PlayerSelect(int n)
    {
        CloseALL();
        Player[n].SetActive(true);
    }
    public void Select(int n)
    {
        PlayerPrefs.SetInt("Player", n);
        selectionPanel.SetActive(false);
        CoinPanel.SetActive(false);
        ScorePanel.SetActive(true);
        mainMenuPanel.SetActive(true);
    }

   
}

