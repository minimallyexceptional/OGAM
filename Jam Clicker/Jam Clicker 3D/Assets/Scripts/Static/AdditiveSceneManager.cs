using UnityEngine;
using UnityEngine.SceneManagement;

static class AdditiveSceneManager
{

    public static void loadScene (int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }

    public static void unloadScene (int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneIndex);
    }

}