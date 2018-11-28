using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstateUpgrade : MonoBehaviour {
    public GameObject clicker;
    public GameObject sellButton;
    public GameObject ground;
    public Sprite upgradeIcon;
    public Sprite stageSprite;
    public string estateName;
    public int estateStage;
    public int descStage;
    public int groundStage;
    public int Cost;
    public int power;
    private Button[] buttons;
    private Image[] images;
    private Text[] itemText;
    private Button buttonSelf;
    private Image iconSelf;
    private Text nameText;
    private Text descText;
    private bool active;
    // Use this for initialization
    void Start()
    {
        this.active = false;
        this.buttons = this.GetComponentsInChildren<Button>(true);
        this.images = this.GetComponentsInChildren<Image>(true);
        this.itemText = this.GetComponentsInChildren<Text>();


        this.iconSelf = this.images[3];
        this.buttonSelf = this.buttons[0];
        this.nameText = this.itemText[1];
        this.descText = this.itemText[2];

        this.buttonSelf.GetComponentInChildren<Text>().text = "x" + this.Cost;
        this.iconSelf.sprite = this.upgradeIcon;

        this.nameText.text = "" + this.estateName + " Stage " + this.descStage + "";
        this.descText.text = "+" + this.power + " Jam Production";

        buttonSelf.onClick.AddListener(() => this.applyUpgrade());

    }

    public void applyUpgrade()
    {
        this.clicker.GetComponent<ClickComponent>().applyUpgrade(this.stageSprite, this.estateStage);
        this.clicker.GetComponent<ClickComponent>().upgradeIncrementAmmount(this.power);
        this.sellButton.GetComponent<SellComponent>().deincrementGold(this.Cost);
        this.ground.GetComponent<GroundManager>().updateGroundStage(this.groundStage);
        this.active = true;
    }

    public void checkButtonStatus()
    {
        if (this.sellButton.GetComponent<SellComponent>().goldValue >= this.Cost && !this.active)
        {
            if (this.clicker.GetComponent<ClickComponent>().currentStage == this.estateStage - 1) {
                this.buttonSelf.interactable = true;
            } else {
                this.buttonSelf.interactable = false;
            }
              
        }
        else {
            this.buttonSelf.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.checkButtonStatus();
    }
}
