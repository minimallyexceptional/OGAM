using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchCanning : MonoBehaviour {

    public GameObject clicker;
    public int Cost;
    private Button[] buttons;
    private Button buttonSelf;
    private bool active;
    // Use this for initialization
    void Start () {
        this.active = false;
        this.buttons = this.GetComponentsInChildren<Button>(true);

        this.buttonSelf = this.buttons[0];
        this.buttonSelf.GetComponentInChildren<Text>().text = "x" + this.Cost;
        buttonSelf.onClick.AddListener(() => this.applyUpgrade());


    }

    public void applyUpgrade()
    {
        clicker.GetComponent<ClickComponent>().upgradeIncrementAmmount(5);
        clicker.GetComponent<ClickComponent>().deincrementScore(this.Cost);
        this.active = true;
    }

    public void checkButtonStatus ()
    {
        if (clicker.GetComponent<ClickComponent>().scoreAmmount >= this.Cost && !this.active)
        {
            this.buttonSelf.interactable = true;
        }
        else
        {
            this.buttonSelf.interactable = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        this.checkButtonStatus();
    }
}
