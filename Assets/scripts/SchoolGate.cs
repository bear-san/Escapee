using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolGate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision Collision) {

		if (Collision.gameObject.CompareTag("Player"))
		{
			Debug.Log("接触しました");
		}
	}

		
}
