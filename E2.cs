using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2 : MonoBehaviour
{
    public delegate void CuboColisionado();
    public static event CuboColisionado OnCuboColisionado;
    public static event CuboColisionado OnCuboColisionadoEsferasG1;
    public static event CuboColisionado OnCuboCercanoAlCilindro;

    private GameObject cilindro;
    public float distanciaMinima = 2.0f;
    private bool dentro = false;
    // Start is called before the first frame update
    void Start()
    {
        cilindro = GameObject.FindWithTag("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(cilindro.transform.position, transform.position);
        if (distancia < distanciaMinima && !dentro)
        {
            OnCuboCercanoAlCilindro?.Invoke();
            dentro = true;
        } else if (distancia > distanciaMinima)
        {
            dentro = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Grupo1")
        {
            OnCuboColisionadoEsferasG1.Invoke();
        } else 
        {
            OnCuboColisionado.Invoke();
        }
    }
}