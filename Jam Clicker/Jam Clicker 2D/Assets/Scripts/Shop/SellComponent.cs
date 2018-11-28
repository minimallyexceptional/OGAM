using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellComponent : MonoBehaviour
{
    public Text goldText;
    public Button sellButton;
    public GameObject clicker;
    public int sellLimit;
    public int cost;
    private int marketingValue;
    public int goldValue;
 

    // Use this for initialization
    void Start()
    {
        this.initalizeGold(0);
        this.marketingValue = 0;
        this.addClickHandler();
    }

    // Update is called once per frame
    void Update()
    {
        this.checkButtonStatus();
        this.updateGold();
    }

    public void checkButtonStatus()
    {
        if (clicker.GetComponent<ClickComponent>().scoreAmmount >= this.sellLimit)
        {
            this.sellButton.interactable = true;
        }
        else
        {
            this.sellButton.interactable = false;
        }
    }

    public void initalizeGold(int gold)
    {
        this.goldValue = gold;
        goldText.text = "" + goldValue;
    }

    public void addClickHandler()
    {
        sellButton.onClick.AddListener(delegate { this.sellJam(this.marketingValue); });
    }

    public void upgradeMarketingValue(int ammount)
    {
        this.marketingValue += ammount;
    }

    public void sellJam (int mv)
    {
        clicker.GetComponent<ClickComponent>().deincrementScore(this.sellLimit);
        this.incrementGold((this.cost + mv) * this.sellLimit);
    }

    public void incrementGold(int ammount)
    {
        this.goldValue += ammount;
    }

    public void deincrementGold(int ammount)
    {
        this.goldValue -= ammount;
    }

    public void updateGold()
    {
        this.goldText.text = "" + this.goldValue;
    }
}
