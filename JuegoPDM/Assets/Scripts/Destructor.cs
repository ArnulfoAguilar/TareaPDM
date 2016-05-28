using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Si colisiona con un colider con tag player se acaba el juego y hay que mostrar el GameOver
            NotificationCenter.DefaultCenter().PostNotification(this, "personajeHaMuerto");
            GameObject personaje = GameObject.Find("Personaje");
            personaje.SetActive(false);
            
        }
        else
        {
            //se destruyen los objetos que chocan contra el
            Destroy(other.gameObject);
        }
    }
}
