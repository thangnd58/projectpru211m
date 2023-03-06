using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    Button buttonPlay;

    [SerializeField]
    Button buttonAmThanh;

    [SerializeField]
    Button buttonHuongDan;



    public void playGame()
    {
        buttonPlay.interactable = true;
        buttonAmThanh.interactable = true;
        buttonHuongDan.interactable = true;
        Time.timeScale = 1;
		SceneManager.LoadScene("GamePlay");
	}

 
    public void setAmThanh()
    {
        
    }
    public void showHuongDan()
    {

    }

}
