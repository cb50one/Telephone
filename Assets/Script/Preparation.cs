using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Preparation : MonoBehaviour
{
    public Text LeftText;
    public Text RightText;
    bool preparationL = false;
    bool preparationR = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            LeftText.text = "OK";
            preparationL = true;
            GameStart();
        }

        if (Input.GetKey(KeyCode.J))
        {
            RightText.text = "OK";
            preparationR = true;
            GameStart();
        }
    }

    public void GameStart()
    {
        if (preparationL && preparationR)
        {
            SceneManager.LoadScene("game");
        }
    }
}
