using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGameButton : MonoBehaviour {
    public void onclick()
    {
        AdditiveSceneManager.unloadScene(1);
        AdditiveSceneManager.loadScene(2);
        AdditiveSceneManager.loadScene(3);
    }
}
