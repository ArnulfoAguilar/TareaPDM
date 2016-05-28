using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {
    private bool aColisionadoConElJugador = false;
    public int puntosGanados=1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        
       // Debug.Log(collision.collider.gameObject.name);
        if(!aColisionadoConElJugador && (collision.collider.gameObject.name =="pataInferiorDerechaB" || collision.collider.gameObject.name == "pataInferiorizquierdaB"))
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos",puntosGanados);
            aColisionadoConElJugador = true;
        }
    }
}
