using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeSystem : MonoBehaviour {


	private Collider actualCollider;
	private float startTime;

	[SerializeField] //PARA QUE SALGA EN INTERFAZ DE UNITY
	private float loadTime;

	[SerializeField]
	private Image loader;

	void OnTriggerEnter(Collider colisionado) { // YO (VARA) HE CHOCADO CON "COLISIONADO"!
		if(actualCollider == null) { 		//SI ANTES ESTABA CHOCANDO CON "NADA"
			actualCollider = colisionado; //AHORA ESTOY COLISIONANDO CON "COLISIONADO"
			startTime = Time.time; //EMPEZAMOS A CONTAR EN TIME.TIME (SEGUNDOS DESDE PLAY)
		}
	}

	void OnTriggerStay(Collider colisionado) { //SEGUIMOS CHOCANDO CON ALGO
		if (actualCollider == colisionado) { //ESE ALGO ES COLISIONADO DE ONTRIGGERENTER?
			float tiempoQueHaPasado = (Time.time - startTime); 
			float porcentajeRellenado = tiempoQueHaPasado / loadTime;
			loader.fillAmount = porcentajeRellenado; //RELLENAMOS EL CIRCULITO DEL LOADER
		}
	}

	void OnTriggerExit(Collider colisionado) {
		actualCollider = null;
		loader.fillAmount = 0;
	}
		

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
