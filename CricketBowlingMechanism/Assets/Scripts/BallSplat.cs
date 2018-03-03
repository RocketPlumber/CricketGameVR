using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSplat : MonoBehaviour {
	public ParticelDecalPool pdp;

	// Use this for initialization
	void Start () {
		pdp = GameObject.Find ("PaintDecalManager").GetComponent<ParticelDecalPool> ();
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "wall") {
			pdp.ParticleHit (col, Color.HSVToRGB (Random.Range (0f, 1f), 1f, 0.7f));
			Debug.Log ("Hit! Splat!");
		}
	}

}
