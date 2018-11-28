using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickComponent : MonoBehaviour {

    public Text scoreText;
    public Button clicker;
    private Object floatingTextController;
    public Sprite stage1;
    public Sprite stage2;
    public Sprite stage3;
    public Sprite stage4;
    public Sprite stage5;
    public int scoreAmmount;
    public int currentStage;
    private int incrementAmmount;
    private Image m_Image;


    // Use this for initialization
    void Start () {
        this.initalizeScore(0);
        this.addClickHandler();
        m_Image = GetComponent<Image>();
        this.applyUpgrade(stage1, 1);
        FloatingTextController.Initalize();
    }
	
	// Update is called once per frame
	void Update () {
        this.updateScore();
	}

    public void initalizeScore (int score)
    {
        scoreAmmount = score;
        scoreText.text = "" + scoreAmmount;
    }

    public void addClickHandler ()
    {
        incrementAmmount = 1;
        clicker.onClick.AddListener(delegate { this.incrementScore(incrementAmmount); });
    }

    public void upgradeIncrementAmmount(int ammount)
    {
        incrementAmmount += ammount;
    }

    public void incrementScore (int ammount)
    {
        scoreAmmount += ammount;
        FloatingTextController.createFloatingText(ammount, this.transform);
    }

    public void deincrementScore(int ammount)
    {
        scoreAmmount -= ammount;
    }

    public void  applyUpgrade (Sprite stageSprite, int estateStage) {

        m_Image.sprite = stageSprite;
        this.currentStage = estateStage;
    }

    public void updateScore ()
    {
        scoreText.text = "" + scoreAmmount;
    }
}
