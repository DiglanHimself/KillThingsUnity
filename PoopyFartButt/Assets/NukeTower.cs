using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeTower : MonoBehaviour
{
    public GameObject baseSpin;
    public GameObject launcherSpin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            Invoke("AdjustShot", 0.0f);
        }
    }

    void AdjustShot()
    {
        Debug.Log("Searching!");
    }
}
