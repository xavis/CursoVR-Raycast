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

	private bool gazed = false;

	private void CheckCollision(RaycastHit golpeado) { //OnTriggerEnter
		if (actualCollider == null || actualCollider != golpeado.collider) {
			actualCollider = golpeado.collider;
			startTime = Time.time;
			gazed = false;
		}
	}

	private void StayCollision(RaycastHit golpeado) { //OnTriggerStay
		if (actualCollider == golpeado.collider) { 
			var porcentajeCarga = (Time.time - startTime) / loadTime;
			loader.fillAmount = porcentajeCarga;
			if (porcentajeCarga >= 1 && !gazed) {
				gazed = true;
				actualCollider.GetComponent<InteractableBehaviour>().OnGaze.Invoke();
			}
		}
	}

	void FixedUpdate() {

		RaycastHit golpeado;

		if (Physics.Raycast (
			    Camera.main.transform.position, //POSICION INICIAL RAYO
			    Camera.main.transform.forward, //DIRECCIÓN LANZADO DEL RAYO
			    out golpeado, //OBJETO CON EL QUE CHOCAMOS
			    20.0f)) {  	 //DISTANCIA

			if (golpeado.collider.tag == "Interactable") {
				CheckCollision (golpeado);
				StayCollision (golpeado);
			}

		} else {
			actualCollider = null;
			gazed = false;
			loader.fillAmount = 0;
		}

	}

}
