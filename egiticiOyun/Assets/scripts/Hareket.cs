using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    leveliniz level;
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangicPozisyonu;
    void Start()
    {
        kamera = GameObject.Find("kamera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("golge");
        baslangicPozisyonu = transform.position;
        level = GameObject.Find("levelgecin").GetComponent<leveliniz>();
    }

    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }
    void Update()

    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject golge in golgeler)
            {
                if (gameObject.name == golge.name)
                {
                    float mesafe = Vector3.Distance(golge.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = golge.transform.position;
                        Destroy(this);
                        level.level2geciliyor();
                    }
                    else
                    {
                        transform.position = baslangicPozisyonu;
                    }

                }
            }
        }
    }
}

