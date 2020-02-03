using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Text timerText;
    public AudioSource audioSource;
    public float countdown;
    int seconds;
    bool gameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        float SoundTime = Random.Range(4f, 10f);
        Invoke("Sound", SoundTime);
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        seconds = (int)countdown;
        timerText.text = seconds.ToString();

        if (countdown < 0)
        {
            timerText.text = "";
        }

        if (Input.GetKey(KeyCode.F))
        {
            if (gameStart)
            {
                SceneManager.LoadScene("FWin");
            }
            else
            {
                SceneManager.LoadScene("JWin");
            }
        }

        if (Input.GetKey(KeyCode.J))
        {
            if (gameStart)
            {
                SceneManager.LoadScene("JWin");
            }
            else
            {
                SceneManager.LoadScene("FWin");
            }
        }
    }

    void Sound()
    {
        audioSource.Play();
        gameStart = true;
    }
}
