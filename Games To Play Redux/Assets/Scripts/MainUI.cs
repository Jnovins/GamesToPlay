using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public SplashLoader loader;

    // Start is called before the first frame update
    void Start()
    {
        //Hide all of the components
    }

    // Update is called once per frame
    void Update()
    {
        if(!loader.loaded) return;

        
    }
}
