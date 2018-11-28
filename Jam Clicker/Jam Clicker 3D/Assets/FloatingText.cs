using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour {

    public Text textValue;
    public Animator animator;

    public void setTextValue(int value) {
        textValue.text = "+" + value;
    }

    // Use this for initialization
    void Start () {
        this.animator = this.GetComponent<Animator>();
        AnimatorClipInfo[] clipInfo = this.animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);


    }
}
