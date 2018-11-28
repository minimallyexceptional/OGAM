using UnityEngine;
using UnityEngine.SceneManagement;

static class Root
{
    public static int Score;


    public static void incrementScore (int ammount)
    {
        Score += ammount;
    }

    public static void deincrementScore(int ammount)
    {
        Score -= ammount;
    }
}