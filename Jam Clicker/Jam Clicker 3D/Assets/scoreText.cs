using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour {

    public Text score;
	
    // Update is called once per frame
	void Update () {
        score.text = "" + Root.Score;
    }
}
