using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This class controls the objects that are displayed on the canvas */

public class UI_Control_Cat : MonoBehaviour {


    // COLOR PICKER
    public GameObject fcp;
    public Image m_ColorButton;
    public Image m_PlayButton;
    public Image m_ProgressBarImage;
    private FlexibleColorPicker fcp_image;
    private bool fcp_shown;

    // PROGRESS BAR
    public GameObject m_ProgressBar;
    public Image m_ProgressButton;
    private bool progress_shown;


    public void ShowColorPicker () {
        if (fcp_shown) {
            fcp.SetActive (false);
            fcp_shown = false;
        } else {
            fcp.SetActive (true);
            fcp_shown = true;
        }
    }

    public void ShowProgressBar () {
        if (progress_shown) {
            m_ProgressBar.SetActive (false);
            progress_shown = false;
        } else {
            m_ProgressBar.SetActive (true);
            progress_shown = true;
        }
    }
   

    // Start is called before the first frame update
    void Start () {
        
        if (fcp != null) {
            fcp.SetActive (false);
            fcp_image = fcp.GetComponent<FlexibleColorPicker> ();
        }
        if (m_ProgressBar != null) {
            m_ProgressBar.SetActive (false);
        }
       
    }


    // Update is called once per frame
    void Update () {
        if (m_PlayButton != null) m_PlayButton.color = fcp_image.color;
        if (m_ColorButton != null) m_ColorButton.color = fcp_image.color;
        if (m_ProgressButton != null) m_ProgressButton.color = fcp_image.color;
        if (m_ProgressBarImage != null) m_ProgressBarImage.color = fcp_image.color;

    }
}