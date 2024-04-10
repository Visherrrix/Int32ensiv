using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    public GameObject MenuPause;
    public float t = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MenuPause.isStatic == true)
        {

        }
        if (MenuPause.isStatic == false) { t -= 1 * Time.deltaTime; }
        if (t < 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
