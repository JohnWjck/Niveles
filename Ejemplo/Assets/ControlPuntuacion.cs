using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPuntuacion : MonoBehaviour {
	public Text textoPuntuacion;
	int puntuacion=0;
	ControlJuego controlJuego;

	void Awake(){
		controlJuego = GameObject.Find ("ControlJuego").GetComponent (typeof(ControlJuego)) as ControlJuego;
	}


	public void SumarPunto(){
		puntuacion++;
		ActualizarTextoPuntuacion ();

		if (puntuacion >= 10) {
			controlJuego.DesbloquearNivel ();
		}

	}

	void ActualizarTextoPuntuacion(){
		textoPuntuacion.text = "Puntos: " + puntuacion.ToString ();
	}

}
