using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(audioscene());
    }
    public IEnumerator audioscene()
    {
        Debug.Log("timee");

        yield return new WaitForSeconds(5);
        Debug.Log("time");
        SceneManager.LoadScene("MainChoice", LoadSceneMode.Single);
    }
   
   
    void Update()
    {
        
    }
}
