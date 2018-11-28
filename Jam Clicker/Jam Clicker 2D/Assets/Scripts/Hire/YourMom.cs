using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourMom : MonoBehaviour
{
    public GameObject clicker;
    public GameObject sellButton;
    public GameObject dayNightSystem;
    public int Cost;
    private Button[] buttons;
    private Button buttonSelf;
    private bool active;
    // Use this for initialization
    void Start()
    {
        this.active = false;
        this.buttons = this.GetComponentsInChildren<Button>(true);

        this.buttonSelf = this.buttons[0];
        this.buttonSelf.GetComponentInChildren<Text>().text = "x" + this.Cost + "/day";
        buttonSelf.onClick.AddListener(() => this.applyUpgrade());

    }

    public void applyUpgrade()
    {
        clicker.GetComponent<ClickComponent>().upgradeIncrementAmmount(5);
        sellButton.GetComponent<SellComponent>().deincrementGold(this.Cost);
        this.active = true;
        this.registerPayment(); 
    }

    public void checkButtonStatus()
    {
        if (sellButton.GetComponent<SellComponent>().goldValue >= this.Cost && !this.active)
        {
            this.buttonSelf.interactable = true;
        }
        else
        {
            this.buttonSelf.interactable = false;
        }
    }

    public void registerPayment()
    {
        this.dayNightSystem.GetComponent<DayNightSystem>().activeCharges.Add(this.Cost);
    }

    // Update is called once per frame
    void Update()
    {
        this.checkButtonStatus();
    }
}
