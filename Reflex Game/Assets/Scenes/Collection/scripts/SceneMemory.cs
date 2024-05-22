using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMemory : MonoBehaviour
{
    private static int previousSceneIndex;
    void Start()
    {
        // ���������� ������ ������� ����� ��� ������ ����
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