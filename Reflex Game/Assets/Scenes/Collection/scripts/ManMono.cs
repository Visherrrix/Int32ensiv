using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMono : MonoBehaviour
{
    public static ManMono instance {  get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
    }

    public GameObject Gal1, Gal2, Gal3, Gal4, Gal5, Gal6;
    public static bool[] ArrGal = { false, false, false, false, false, false, false, false };
    public static bool hf = false;
    // Start is called before the first frame update
    

    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            //Debug.Log(ArrGal[i]);
            if (ArrGal[i] == true && hf)
            {
                
                
                if (i == 0) { Renderer a = Gal1.GetComponent<Renderer>(); a.enabled = true; }
                if (i == 7) { Renderer b = Gal6.GetComponent<Renderer>(); b.enabled = true; }
                if (i == 6) { Renderer c = Gal5.GetComponent<Renderer>(); c.enabled = true; }
                if (i == 3) { Renderer d = Gal2.GetComponent<Renderer>(); d.enabled = true; }
                if (i == 4) { Renderer e = Gal3.GetComponent<Renderer>(); e.enabled = true; }
                if (i == 5) { Renderer f = Gal4.GetComponent<Renderer>(); f.enabled = true; }

            }
        }
    }
}
