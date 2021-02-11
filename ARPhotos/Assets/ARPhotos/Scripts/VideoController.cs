using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Vuforia;

/* This class controls the VideoPlayer */ 

public class VideoController : MonoBehaviour, IVirtualButtonEventHandler {

    private bool vb_active;

    public VideoPlayer videoPlayer;
    public Button playButton;
    public Sprite playIcon;
    public Sprite pauseIcon;
    public RectTransform progressBar;
    public GameObject virtualButton;

    void Start () {
        if (virtualButton != null) {
            virtualButton = GameObject.Find ("VButton");
            virtualButton.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
            virtualButton.SetActive (false);

        }
    }

    void Update () {
        if (videoPlayer.isPlaying) {
            playButton.GetComponent<UnityEngine.UI.Image> ().sprite = pauseIcon;

        } else {
            playButton.GetComponent<UnityEngine.UI.Image> ().sprite = playIcon;
        }
    }

    void OnApplicationPause (bool pause) {
        if (pause)
            videoPlayer.Pause();
    }

    public void Play () {
        if (videoPlayer.isPlaying) {
            videoPlayer.Pause ();

        } else {
            videoPlayer.Play ();
        }
    }

    public void Pause(){
        videoPlayer.Pause ();
    }


    public void ActivateVirtualButton () {
        if (vb_active) {
            vb_active = false;
            virtualButton.SetActive (false);
        } else {
            vb_active = true;
            virtualButton.SetActive (true);
        }
    }

    // Controls the Virtual Button
    public void OnButtonPressed (VirtualButtonBehaviour vb) {
        if (vb_active) Play ();
    }

    public void OnButtonReleased (VirtualButtonBehaviour vb) {
        
    }

    //Controls the Size
    public void IncreaseSize(){
        transform.localScale *= 1.1f;
    }

    public void DecreaseSize(){
        transform.localScale /= 1.1f;
    }

    public void NormalSize(){
        transform.localScale = new Vector3(10F, 10F, 10F);
    }

}