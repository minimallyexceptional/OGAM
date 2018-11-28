using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightSystem : MonoBehaviour {

    public float dayMiliseconds;
    public GameObject sellButton;
    public List<int> activeCharges;
    private int dayCount;
    private bool sunIsUp;
    public Text dayText;
    public Light sunLight;
	// Use this for initialization
	void Start () {
        this.sunIsUp = false;
        InvokeRepeating("incrementDay", 0.0f, this.dayMiliseconds);
    }
	
	// Update is called once per frame
	void Update () {
        if (sunIsUp) {
            this.sunLight.color -= (Color.white / (this.dayMiliseconds / 1.5f)) * Time.deltaTime;
        } else {
            this.sunLight.color += (Color.white / (this.dayMiliseconds / 1.5f)) * Time.deltaTime;
        }
    }

    public void incrementDay () {
        this.sunIsUp = !this.sunIsUp;
        this.dayCount += 1;
        this.dayText.text = "Day  " + this.dayCount;
        this.applyCharges();
    }

    public void sunDown () {
        this.sunIsUp = false;
    }

    public void sunUp() {
        this.sunIsUp = true;
    }

    public void applyCharges () {
        this.activeCharges.ForEach((cost) => sellButton.GetComponent<SellComponent>().deincrementGold(cost));
    }
}
