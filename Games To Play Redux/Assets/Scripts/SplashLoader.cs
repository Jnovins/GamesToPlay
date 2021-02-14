using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Diagnostics;
using System;

public class SplashLoader : MonoBehaviour
{
    public GameObject loadingImage;
    public Slider slider;

    public Stopwatch stopwatch;

    public bool loaded;
    public int loadTime = 10000;
    public float progress;

    // Start is called before the first frame update
    void Start()
    {
        loaded = false;
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch.Stop();
        TimeSpan ts = stopwatch.Elapsed;
        stopwatch.Start();
        double millisPassed = ts.TotalMilliseconds;
        progress = (float)(millisPassed/loadTime);

        slider.value = progress;

        if(progress >= 1){
            loaded = true;

            Transform[] children = gameObject.GetComponentsInChildren<Transform>();
            foreach(Transform t in children){
                t.gameObject.SetActive(false);
            }
            this.enabled= false;
        }
    }
}
