using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundManager : MonoBehaviour {

    public Sprite stage1;
    public Sprite stage2;
    public int currentStage;
    public Image currentImage;

    public void checkStageSprite(int stage) {
        switch (stage) {
            case 1: this.currentImage.sprite = stage1; break;
            case 2: this.currentImage.sprite = stage2; break;
        }
    }

    public void updateGroundStage(int stage) {
        this.currentStage = stage;
    }

	// Use this for initialization
	void Start () {
        this.checkStageSprite(this.currentStage);
    }
	
	// Update is called once per frame
	void Update () {
        this.checkStageSprite(this.currentStage);
	}
}
