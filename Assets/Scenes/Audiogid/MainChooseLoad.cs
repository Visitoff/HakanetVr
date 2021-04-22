using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainChooseLoad : MonoBehaviour
{
    public AudioClip grandmaAudio;
    IEnumerator audiolegth()
    {
        yield return new WaitForSeconds(grandmaAudio.length);
        SceneManager.LoadScene("Audiogid", LoadSceneMode.Single);
    }

    void Start()
    {
        StartCoroutine(audiolegth());

    }

    void Update()
    {

    }
}
