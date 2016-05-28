using UnityEngine;
using System.Collections;

public class seguirPersonaje : MonoBehaviour {
    public Transform personaje;
    public float separacion=6.85f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(personaje.position.x+separacion, transform.position.y, transform.position.z);
	}
}
