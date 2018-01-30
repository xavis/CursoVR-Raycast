using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour {

	void CerrarMenu() {
		this.gameObject.SetActive (false);
	}

	public void GirarMenu() {
		this.GetComponent<Animator> ().Play ("Girar");
		//PONER ROTACION A 0 después de nuevo:)
	}

	public void IniciarCerrado() {
		this.GetComponent<Animator> ().Play ("ToggleMenuCerrar");
		Invoke("CerrarMenu", 0.5f);
	}

}
