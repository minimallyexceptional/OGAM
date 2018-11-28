﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextController : MonoBehaviour {
    private static FloatingText floatingText;
    private static GameObject canvas;
    private static GameObject clicker;

    public static void Initalize () {
        canvas = GameObject.Find("TextTarget");
        clicker = GameObject.Find("Clicker");
        floatingText = Resources.Load<FloatingText>("Prefabs/FloatingText");
    }

    public static void createFloatingText (int ammount, Transform location) {
        FloatingText instance = Instantiate(floatingText);
        instance.transform.SetParent(canvas.transform, false);
        instance.setTextValue(ammount);
    }
}
