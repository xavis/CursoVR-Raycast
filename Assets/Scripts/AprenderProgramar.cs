using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AprenderProgramar : MonoBehaviour {

	private int contador = 0;

	private int dos = 2;
	private int cinco = 5;
	private int resultado;

	private GameObject crearGO() {
		var miGO = new GameObject ();
		//miGO.name = "hola";
		return miGO;
	}

	private void unir2(string cadena) {
		var dos = 2;
		string cadenaFinal = cadena + dos;
	}

	private int sumarBVeces(int A, int B) {
		//for(prebucle; condicion fin; postvuelta)
		var resultado = A;
		for(int i = 0; i < B; i = i + 1) {
			resultado = resultado + A;
		}
		return resultado;
	}

	private int sumarSiEsMayorOIgual3(int A, int B){
		if (A > 2 || B > 2) {
			/*
			 * > mayor que
			 * < menor que
			 * >= mayor o igual que
			 * <= menor o igual que
			 * == igual que
			 * != distinto de
			 * */
			return sumarDevolviendo (A, B);
		}	
		return 0;
	}

	private int sumarDevolviendo (int A, int B) {
		return A + B;
	}

	private void sumarSinDevolver (int A, int B) {
		resultado = A + B;
	}

	private void lanzarSumarParaQueDeSiete () {
		int siete = sumarDevolviendo (dos, cinco); //Devuelve 7
		int cacahuete = sumarDevolviendo (dos, 6);
		int nueve = sumarDevolviendo (dos, 7);
		sumarSinDevolver(dos, cinco);
		sumarSinDevolver(dos, cinco);
		sumarSinDevolver(dos, cinco);
		sumarDevolviendo (10, 5);
	}

	private void contar() {
		contador = contador + 1;
	}

	/*
		bool  //true false
		int   // numeros enteros ( -10000000 a 10000000)
		float // numeros decimales
		double // numeros decimales 
		string // Cadenas texto "hola que tal"
		GameObject // Objeto básico Unity
		Transform // Situar, girar y escalar un objeto en el mundo
		Collider // Gestionan colisiones
		Color 
		Vector2 // x,y
		Vector3 // x,y,z
		Quaternion  // x,y,z,w
	*/


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
