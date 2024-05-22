using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMemory : MonoBehaviour
{
    private static int previousSceneIndex;
    void Start()
    {
        // Запоминаем индекс текущей сцены при старте игры
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public static int GetPreviousSceneIndex()
    {
        return previousSceneIndex;
    }

    public static void SetPreviousSceneIndex(int index)
    {
        previousSceneIndex = index;
    }
}