using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
    public float velocidad=0f;
    //al principio no queremos que el scroll se este moviendo
    private bool enMovimiento = false;
    //para que el tiempo empieze a contar desde que se mueve el personaje
    private float tiempoInicio=0f;
    public bool iniciarEnMovimiento = false;

	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajEmpiezaCorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "personajeHaMuerto");
        if (iniciarEnMovimiento)
        {
            enMovimiento = true;
        }
    }
    void personajeHaMuerto()
    {
        enMovimiento = false;
    }

    void PersonajEmpiezaCorrer()
    {
        enMovimiento = true;
        tiempoInicio = Time.time;//se hace que el tiempo empieze a contar desde que se activa el personaje 
    }

    // Update is called once per frame
    void Update () {
        //solo se cambiara el offset de la textura si el personaje esta en movimiento
        if (enMovimiento)
        {
            //para que el fondo se mueva a diferente velocidad y haga un efecto de scroll
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(((Time.time-tiempoInicio)*velocidad)%1, 0);
        }
	}
}
