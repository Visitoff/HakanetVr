using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrVideoControl : MonoBehaviour
{
    [SerializeField]
    GameObject neftVideoSphere;
    GameObject mainSphere;
    [SerializeField]
    int vrModeForSphere;

    [SerializeField]
    GameObject HistoryVideoSphere;

    private void Awake()
    {
        mainSphere = GameObject.FindGameObjectWithTag("Sphere");
        vrModeForSphere = mainSphere.GetComponent<MainChoicScript>().vrMode;
        if(vrModeForSphere == 1)
        {
            HistoryVideoSphere.SetActive(false);
        }
        else
        {
            neftVideoSphere.SetActive(false);
        }
    }
    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
