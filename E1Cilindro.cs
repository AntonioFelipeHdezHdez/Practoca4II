using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1 : MonoBehaviour
{
    public delegate void CilindroColisionado();
    public static event CilindroColisionado OnCilindroColisionado;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            OnCilindroColisionado.Invoke();
        }
    }

}
