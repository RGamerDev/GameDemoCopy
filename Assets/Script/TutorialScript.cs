﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public GameObject CoinUi;
    private static int Coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene(0);
        PausedMenu.PauseMenuUI = PauseMenuUI;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedMenu.GameIsPaused)
            {
                PausedMenu.resume();
            }
            else
            {
                PausedMenu.Pause();
            }
        }

        CoinUi.GetComponent<Text>().text = $"Coins: {Coins.ToString()}";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Coins++;
            SceneManager.LoadScene(2);
        }
    }
}
