using UnityEngine;
using System.Collections;

public class ActualizarGameOver : MonoBehaviour {
    public TextMesh total;
    public TextMesh record;
    public Puntuacion puntuacion;
    public EstadoJuego estadoJuego;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnEnable()
    {
        total.text = puntuacion.puntuacion.ToString();
        record.text = estadoJuego.puntuacionMaxima.ToString();
    }
}
