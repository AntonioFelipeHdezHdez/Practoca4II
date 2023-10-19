using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1Esferas : MonoBehaviour
{
    public GameObject objetivo;
    // Start is called before the first frame update
    void Start()
    {
        E1.OnCilindroColisionado += CambioEsferas;
        E2.OnCuboColisionado += CambioEsferas2;
        E2.OnCuboColisionadoEsferasG1 += CambioEsferas3;
        E2.OnCuboCercanoAlCilindro += CambioEsferas4;

        objetivo = GameObject.FindWithTag("Objetivo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CambioEsferas()
    {
        if (this.tag == "Grupo1")
        {
            this.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);;
        }
        else if (this.tag == "Grupo2")
        {
            Vector3 direccion = GameObject.Find("Cylinder2").transform.position - this.transform.position;
            this.transform.position += direccion.normalized;
        }
    }

    private void CambioEsferas2()
    {
        if (this.tag == "Grupo1")
        {
            Vector3 direccion = GameObject.Find("Cylinder").transform.position - this.transform.position;
            this.transform.position += direccion.normalized;
        }
    }

   private void CambioEsferas3()
    {
        if (this.tag == "Grupo2")
        {
            this.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
        }
    }

    private void CambioEsferas4()
    {
        if (this.tag == "Grupo1")
        {
            this.GetComponent<Renderer>().material.color = Random.ColorHSV();
            
            // Salto: https://docs.unity3d.com/ScriptReference/Rigidbody.AddForce.html
            // AddForce(direccion, modo)
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 8, ForceMode.Impulse);
        }
        else if (this.tag == "Grupo2")
        {
            this.transform.LookAt(objetivo.transform);
        }
    }

}
