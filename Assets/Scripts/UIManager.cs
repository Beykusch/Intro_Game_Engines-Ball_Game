using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public AudioSource bgsound;
    public Slider volumeSlider;
    public MouseLook mouseLook;
    public Throw throwScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VolumeControl()
    {
        bgsound.volume = volumeSlider.value;
    }

    public void StartGame()
    {
        mainMenu.SetActive(false); 
        mouseLook.enabled = true;
        throwScript.enabled = true;
    }
}
