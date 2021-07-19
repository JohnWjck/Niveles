using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlJuego : MonoBehaviour {

	static public int nivelesDesbloqueados;
	public int nivelActual;
	public Button[] botonesMenu;
	CargarYGuardar cargarYGuardar;

	void Awake(){
		cargarYGuardar = GetComponent<CargarYGuardar> ();
	}

	void Start(){
		if (SceneManager.GetActiveScene ().name == "Menu") {
			cargarYGuardar.Guardar ();
			ActualizarBotones ();
		}
	}


	public void CambiarNivel(int nivel){
		if (nivel == 0) {
			SceneManager.LoadScene ("Menu");
		} else {
			SceneManager.LoadScene ("Nivel_" + nivel);
		}
	}

	public void DesbloquearNivel(){
		if (nivelesDesbloqueados < nivelActual) {
			nivelesDesbloqueados = nivelActual;
			nivelActual++;
		}
		VolverAlMenu ();

	}

	void VolverAlMenu(){
		CambiarNivel (0);
	}

	public void ActualizarBotones(){
		for (int i = 0; i < nivelesDesbloqueados+1; i++) {
			botonesMenu [i].interactable = true;
		}
	}


}
