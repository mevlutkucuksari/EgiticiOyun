using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveliniz : MonoBehaviour
{
    float ilksayi = 0;
    public GameObject LevelPaneli;
    
    public void level2geciliyor()
    {
        
        float sayi = 3;
        ilksayi++;
        Debug.Log(ilksayi);
        if (ilksayi == sayi)
        {
            LevelPaneli.SetActive(true);
        }
    }
    
    public void level3geciliyor()
    {
        
        float sayi = 2;
        ilksayi++;
        Debug.Log(ilksayi);
        if (ilksayi == sayi)
        {
            LevelPaneli.SetActive(true);
        }
    }
    public void level4geciliyor()
    {
        
        float sayi = 4;
        ilksayi++;
        Debug.Log(ilksayi);
        if (ilksayi == sayi)
        {
            LevelPaneli.SetActive(true);
        }
    }
    public void level5geciliyor()
    {
        
        float sayi = 3;
        ilksayi++;
        Debug.Log(ilksayi);
        
        if (ilksayi == sayi)
        {
            LevelPaneli.SetActive(true);
        }
    }
    public void oyunekrani()
    {
        SceneManager.LoadScene(1);
    }
    public void menuekrani()
    {
        SceneManager.LoadScene(0);
    }
    public void cikis()
    {
        Application.Quit();
    }
    public void levelEkrani()
    {
        LevelPaneli.SetActive(true);
    }
    public void levelekraniCikis()
    {
        LevelPaneli.SetActive(false);
    }

    public void sorular()
    {
        SceneManager.LoadScene(1);
    }
    public void level1()
    {
        SceneManager.LoadScene(2);
    }
    public void level2()
    {
        SceneManager.LoadScene(3);
    }
    public void level3()
    {
        SceneManager.LoadScene(4);
    }
    public void level4()
    {
        SceneManager.LoadScene(5);
    }
    public void tebrikler()
    {
        SceneManager.LoadScene(6);
    }


}
