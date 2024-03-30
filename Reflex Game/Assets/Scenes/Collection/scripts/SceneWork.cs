using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWork : MonoBehaviour
{
    [Header("Номер сцены для перехода")]
    public int sceneNumber;
    public void Transition()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
