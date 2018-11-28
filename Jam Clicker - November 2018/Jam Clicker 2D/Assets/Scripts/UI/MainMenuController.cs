using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    public GameObject upgradePanel, shopPanel, hiringPanel, estatePanel;
    public Button homeButton, upgradeButton, shopButton, hiringButton, estateButton;
    private GameObject activePanel;

	// Use this for initialization
	void Start () {
        this.initPanels();
        this.initButtons();
	}
	
    public void initPanels ()
    {
        if (upgradePanel != null)
            this.togglePanel(upgradePanel, false);
        if (shopPanel != null)
            this.togglePanel(shopPanel, false);
        if (hiringPanel != null)
            this.togglePanel(hiringPanel, false);
        if (estatePanel != null)
            this.togglePanel(estatePanel, false);

        this.activePanel = null;
    }

    public void initButtons()
    {
        homeButton.onClick.AddListener(() => clearPanels());
        upgradeButton.onClick.AddListener(delegate { togglePanel(upgradePanel, true); });
        shopButton.onClick.AddListener(delegate { togglePanel(shopPanel, true); });
        hiringButton.onClick.AddListener(delegate { togglePanel(hiringPanel, true); });
        estateButton.onClick.AddListener(delegate { togglePanel(estatePanel, true); });
    }

    public void togglePanel (GameObject panel, bool status)
    {
        if (this.activePanel == panel)
        {
            panel.gameObject.SetActive(false);
            this.activePanel = null;
        } else
        {
            this.clearPanels();
            panel.gameObject.SetActive(status);
            this.activePanel = panel;
        }
    }

    public void clearPanels ()
    {
        if (this.activePanel != null)
        {
            this.activePanel.gameObject.SetActive(false);
            this.activePanel = null;
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
