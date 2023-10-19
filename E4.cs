using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class E4 : MonoBehaviour
{
    
    private int puntuacion = 0;
    public TextMeshProUGUI puntuacionText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grupo1")
        {
            puntuacion += 5;
            other.gameObject.SetActive(false);
            Debug.Log("Puntuación: " + puntuacion);
            puntuacionText.text = "Puntuación: " + puntuacion;
        }
        else if (other.gameObject.tag == "Grupo2")
        {
            puntuacion += 10;
            other.gameObject.SetActive(false);
            Debug.Log("Puntuación: " + puntuacion);
            puntuacionText.text = "Puntuación: " + puntuacion;
        }
    }

}
