using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBacker : MonoBehaviour
{
    public void SceneBack()
    {
            SceneManager.LoadScene(SceneMemory.GetPreviousSceneIndex());  
    }
}
