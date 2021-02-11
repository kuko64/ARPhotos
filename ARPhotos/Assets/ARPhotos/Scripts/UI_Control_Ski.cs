using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This class controls the objects that are displayed on the canvas */

public class UI_Control_Ski : MonoBehaviour {

    public Image m_PlayButton;
  
    // AR INFO
    public GameObject m_InfoButton;
    public GameObject m_InfoObjects;
    private bool info_shown;
    private Image infobutton_image;

    public void GetInfo () {
        if (info_shown) {
            m_InfoObjects.SetActive (false);
            info_shown = false;
        } else {
            m_InfoObjects.SetActive (true);
            info_shown = true;
        }
    }

   

    // Start is called before the first frame update
    void Start () {
        if (m_InfoObjects != null) {
            m_InfoObjects.SetActive (false);
            infobutton_image = m_InfoButton.GetComponent<Image> ();
        }
    }


    // Update is called once per frame
    void Update () {

    }
}