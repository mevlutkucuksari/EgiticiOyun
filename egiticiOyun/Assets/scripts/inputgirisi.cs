using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inputgirisi : MonoBehaviour
{
    public GameObject soru1tik;
    public GameObject soru2tik;
    public GameObject soru3tik;
    public GameObject soru4tik;
    public InputField soru1;
    string soru1cevabi = "telli";
    public InputField soru2;
    string soru2cevabi = "vurmalý";
    public InputField soru3;
    string soru3cevabi = "tuþlu";
    public InputField soru4;
    string soru4cevabi = "üflemeli";
    float dogrular=0;

    public GameObject LevelPaneli;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (soru1.text == soru1cevabi)
        {
            dogrular = 1;
            Debug.Log(dogrular);
            soru1tik.SetActive(true);
        }
        if (soru2.text == soru2cevabi)
        {
            dogrular = 2;
            soru2tik.SetActive(true);
            Debug.Log(dogrular);
        }
        if (soru3.text == soru3cevabi)
        {
            dogrular = 3;
            soru3tik.SetActive(true);
            Debug.Log(dogrular);
        }
        if (soru4.text == soru4cevabi)
        {
            dogrular = 4;
            soru4tik.SetActive(true);
            Debug.Log(dogrular);
        }
        if (dogrular == 4)
        {
            
        }
    }
    public void siradakisoru()
    {
        if (dogrular == 4)
        {
            LevelPaneli.SetActive(true);
        }
    }
}
