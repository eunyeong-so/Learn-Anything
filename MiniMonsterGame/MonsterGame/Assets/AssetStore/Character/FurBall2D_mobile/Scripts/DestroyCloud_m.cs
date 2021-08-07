using UnityEngine;
using System.Collections;

public class DestroyCloud_m : MonoBehaviour {

	public float DestroyTime;

	void Start(){
		Invoke("DestroyIt", DestroyTime);
	}

	void DestroyIt(){
		Destroy(gameObject);
	}
}