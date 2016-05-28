using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
    public GameObject[] obj;
    public float tiempoMin = 1.25f;
    public float tiempoMax = 2.5f;
    private bool fin=false;// si el personaje muere con esta variable se dejara de generar bloques 

	// Use this for initialization
	void Start () {
        // Generar();
        //esto lo que hara es que va a ir creando los bloques conforme la camara se mueva
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajEmpiezaCorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "personajeHaMuerto");

    }

    void personajeHaMuerto()
    {
        fin = true;
    }

    //metodo para notificar si el personaje ha empezado a correr
    void PersonajEmpiezaCorrer(Notification notificacion)
    {
        
            //Cuando se tenga la notificacion que el personaje se empieza a mover se generaran los bloques
            Generar();
        
    }


    // Update is called once per frame
    void Update () {
        
	}

    void Generar()
    {
        if (!fin)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            //Se invoca el mismo metodo en un rango de tiempo para que genere los bloques
            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
        }
    }

}
