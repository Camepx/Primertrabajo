using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject micar;
    public float velocidad = 20f;
    public GameObject bala;
   
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-2.35F, 1.3F, -7.14F);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.forward * Time.deltaTime; 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime;
        }
        //Cuando presione la tecla DOWN el carro avanza hacia atras o en reversa
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime;
        }
        //Cuando presione la tecla RIGCHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += Vector3.right * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, velocidad * Time.deltaTime, 0);
        }
        //Cuando presione la tecla LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position -= Vector3.right * Time.deltaTime;
            transform.eulerAngles -= new Vector3(0, velocidad * Time.deltaTime, 0);
        }
        //Cuando presione la letra A hago un turbo
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
        //Cuando presione la letra space hago un disparo
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bala, transform.position, transform.rotation);
        }
    }
}
