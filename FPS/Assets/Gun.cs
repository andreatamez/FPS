using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Gun : MonoBehaviour {

	public Camera fpsCam;

	//damage que da al objeto
	public float damage = 10f;
	//range a donde puede llegar 
	public float range = 100f;
	private int capsulesDestroyed = 0;

	//mi void Start para el tiempo
	private int tiempo;
	void Start () { 
		// txt.text = "Tiempo: " + iCube.ToString (); 
		InvokeRepeating("OutputTime", 1f, 1f);
		tiempo = 60;
	}

	void OutputTime() {
		tiempo--;
		// txt.text = "Tiempo: " + iCube.ToString ();
		if (tiempo == 0) {
			Application.LoadLevel ("LOSE");
		}
	}
	
	// Update is called once per frame
	void Update () {

		//LeftMouse Button ya decidido por unity
		if (Input.GetButtonDown ("Fire1")) {
			Shoot ();
		}

		if (Input.GetKey ("escape")) {
			Application.Quit ();
		}
	}

	void Shoot(){
		RaycastHit hit;

		//regresa true si le diste hit a algo false si no
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {

			//te da el nombre de lo que golpeaste
			Debug.Log (hit.transform.name);

			//Si golpea una capsula suma cuantas golpeaste y asi puedes ganar 
			if (hit.transform.name.ToString () == "Capsule") {
				capsulesDestroyed++;
				Destroy (hit.transform.gameObject);
				if (capsulesDestroyed == 6) {
					Debug.Log ("Ganaste");
					Application.LoadLevel ("WIN");
				}
			}
		}
	}
}
