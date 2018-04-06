using UnityEngine;

public class Gun : MonoBehaviour {

	public Camera fpsCam;

	//damage que da al objeto
	public float damage = 10f;
	//range a donde puede llegar 
	public float range = 100f;
	
	// Update is called once per frame
	void Update () {

		//LeftMouse Button ya decidido por unity
		if (Input.GetButtonDown ("Fire1")) {
			Shoot ();
		}
	}

	void Shoot(){
		RaycastHit hit;

		//regresa true si le diste hit a algo false si no
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {

			//te da el nombre de lo que golpeaste
			Debug.Log (hit.transform.name);
		}
	}
}
