using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This class controls the objects that are displayed on the canvas */

public class UI_Control_Aquarium : MonoBehaviour {

    public Image m_PlayButton;

    //SIZE SETTINGS
    public GameObject m_SizePlus;
    public GameObject m_SizeMinus;
    private bool size_shown;

    public void ShowSizeSettings(){
        if(size_shown){
            m_SizePlus.SetActive (false);
            m_SizeMinus.SetActive (false);
            size_shown = false;
        } else {
            m_SizePlus.SetActive (true);
            m_SizeMinus.SetActive (true);
            size_shown = true;
        }
    }

   

    // Start is called before the first frame update
    void Start () {
      
        if (m_SizePlus != null && m_SizeMinus != null) {
            m_SizePlus.SetActive (false);
            m_SizeMinus.SetActive (false);
        }
    }


    // Update is called once per frame
    void Update () {
    

    }
}