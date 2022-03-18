using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //pregunto si en este objeto le pego o colisiono contra el objeto que tiene el tag de Carro
        if (collision.gameObject.tag == "Carro")
        {
            // En la consola de Unity aparece que perdi
            Debug.Log("Game Over");
            SceneManager.LoadScene("EscenaLaberinto");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
