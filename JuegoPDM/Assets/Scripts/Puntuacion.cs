using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {
    public int puntuacion = 0;
    public TextMesh marcador;
	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        NotificationCenter.DefaultCenter().AddObserver(this, "personajeHaMuerto");
        ActualizarMarcador();
    }

    void personajeHaMuerto(Notification notificacion)
    {
        if (puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima)
        {
            EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
            EstadoJuego.estadoJuego.Guardar();

        }
    }
    //El metodo que se llamara cuando se incremente los puntos 
    void IncrementarPuntos(Notification notificacion)
    {
        int puntosAIncrementar =(int) notificacion.data;
        puntuacion += puntosAIncrementar;
        ActualizarMarcador();
    }
    void ActualizarMarcador()
    {
        marcador.text = puntuacion.ToString();
        
    }
	// Update is called once per frame
	void Update () {
	
	}
}
