using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;


public class MainChoicScript : MonoBehaviour
{
    GameObject sreda;
    GameObject chetverg;
    GameObject friday;
    int score;
    int qNum = 0;
    Renderer WrongMat;
    GameObject q1;
    GameObject q2;
    GameObject q3;
    GameObject q4;
    GameObject q5;
    GameObject q6;
    GameObject q7;
    GameObject q8;
    GameObject q9;
    GameObject q10;
    GameObject win;
    GameObject lose;
    bool exitFrom360;
    public int vrMode = 0;
    bool readyToChoice;
    AudioClip babkaTalk;
    private void Start()
    {

    }

    IEnumerator AudioGidMain()
    {
        yield return new WaitForSeconds(1);
        GameObject audiobabka = GameObject.FindGameObjectWithTag("audio");
        AudioSource audio = audiobabka.GetComponent<AudioSource>();
        audio.Play();
    }
    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainChoice", LoadSceneMode.Single);
        StartCoroutine(AudioGidMain());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "afisha")
        {
            SceneManager.LoadScene("afisha", LoadSceneMode.Single);
            StartCoroutine(afisha());
            IEnumerator afisha()
            {
                yield return new WaitForSeconds(3);
                Debug.Log("a");
                sreda = GameObject.FindGameObjectWithTag("sreda");
                chetverg = GameObject.FindGameObjectWithTag("chetverg");
                friday = GameObject.FindGameObjectWithTag("friday");
                chetverg.SetActive(false);
                friday.SetActive(false);
            }

        }

        if (other.tag == "CP")
        {
            Debug.Log("af");
            sreda.SetActive(true);
            chetverg.SetActive(false);
            friday.SetActive(false);
        }
        if (other.tag == "CHT")
        {
            sreda.SetActive(false);
            chetverg.SetActive(true);
            friday.SetActive(false);
        }
        if (other.tag == "PT")
        {
            sreda.SetActive(false);
            chetverg.SetActive(false);
            friday.SetActive(true);
        }


        if (other.tag == "55+")
        {
            Debug.Log("a");
            SceneManager.LoadScene("55+", LoadSceneMode.Single);
            StartCoroutine(five());
            IEnumerator five()

            {
                yield return new WaitForSeconds(2);
                q1 = GameObject.FindGameObjectWithTag("1");
                q2 = GameObject.FindGameObjectWithTag("2");
                q3 = GameObject.FindGameObjectWithTag("3");
                q4 = GameObject.FindGameObjectWithTag("4");
                q5 = GameObject.FindGameObjectWithTag("5");
                q6 = GameObject.FindGameObjectWithTag("6");
                q7 = GameObject.FindGameObjectWithTag("7");
                q8 = GameObject.FindGameObjectWithTag("8");
                q9 = GameObject.FindGameObjectWithTag("9");
                q10 = GameObject.FindGameObjectWithTag("10");
                win = GameObject.FindGameObjectWithTag("win");
                lose = GameObject.FindGameObjectWithTag("lose");
                q2.SetActive(false);
                q3.SetActive(false);
                q4.SetActive(false);
                q5.SetActive(false);
                q6.SetActive(false);
                q7.SetActive(false);
                q8.SetActive(false);
                q9.SetActive(false);
                q10.SetActive(false);
                win.SetActive(false);
                lose.SetActive(false);
            }

        }
        if (other.tag == "wrong")
        {
            WrongMat = other.GetComponent<Renderer>();
            WrongMat.sharedMaterial.color = Color.red;
            GameObject trueq = GameObject.FindGameObjectWithTag("true");
            Renderer trueMat = trueq.GetComponent<Renderer>();
            trueMat.sharedMaterial.color = Color.green;
            qNum++;
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                WrongMat.sharedMaterial.color = Color.white;
                trueMat.sharedMaterial.color = Color.white;
            }
        }
        if (other.tag == "true")
        {
            GameObject trueq = GameObject.FindGameObjectWithTag("true");
            Renderer trueMat = trueq.GetComponent<Renderer>();
            trueMat.sharedMaterial.color = Color.green;
            qNum++;
            score++;
            StartCoroutine(answers());
            IEnumerator answers()
            {
                yield return new WaitForSeconds(3);
                WrongMat.sharedMaterial.color = Color.white;
                trueMat.sharedMaterial.color = Color.white;
            }
        }



        if (other.tag == "vr")
        {
            Debug.Log("a");
            SceneManager.LoadScene("VrVideoChoice", LoadSceneMode.Single);


        }
        if (other.tag == "neft")
        {
            SceneManager.LoadScene("360gid", LoadSceneMode.Single);
            vrMode++;
            exitFrom360 = true;
        }
        if (other.tag == "history")
        {
            SceneManager.LoadScene("360gid", LoadSceneMode.Single);
            vrMode += 2;
            exitFrom360 = true;
        }




    }
    private void Update()
    {
        if (SteamVR_Actions._default.GrabGrip.GetStateDown(SteamVR_Input_Sources.Any))
        {
            SceneManager.LoadScene("MainChoice", LoadSceneMode.Single);

        }
        if (qNum == 1)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q1.SetActive(false);
                q2.SetActive(true);
            }
        }
        if (qNum == 2)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q2.SetActive(false);
                q3.SetActive(true);
            }
        }
        if (qNum == 3)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q3.SetActive(false);
                q4.SetActive(true);
            }
        }
        if (qNum == 4)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q4.SetActive(false);
                q5.SetActive(true);
            }
        }
        if (qNum == 5)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q5.SetActive(false);
                q6.SetActive(true);
            }
        }
        if (qNum == 6)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q6.SetActive(false);
                q7.SetActive(true);
            }
        }
        if (qNum == 7)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q7.SetActive(false);
                q8.SetActive(true);
            }
        }
        if (qNum == 8)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q8.SetActive(false);
                q9.SetActive(true);
            }
        }
      /*  if (qNum == 9)
        {
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(3);
                q9.SetActive(false);
                q10.SetActive(true);
            }
        }*/
        if (qNum == 9)
        {
           
            StartCoroutine(answers());
            IEnumerator answers()

            {
                yield return new WaitForSeconds(2);
                q9.SetActive(false);



                if (score > 5)
                {
                    win.SetActive(true);

                    StartCoroutine(corotine());
                    IEnumerator corotine()
                    {
                        yield return new WaitForSeconds(3);
                        SceneManager.LoadScene("MainChoice", LoadSceneMode.Single);
                        SceneManager.UnloadSceneAsync("55+");
                    }
                }
                if (score < 5)
                {

                    lose.SetActive(false);
                    StartCoroutine(corotine());
                    IEnumerator corotine()
                    {
                        yield return new WaitForSeconds(3);
                        SceneManager.LoadScene("MainChoice", LoadSceneMode.Single);
                        SceneManager.UnloadSceneAsync("55+");
                    }

                }
            }
        }
    }
}
