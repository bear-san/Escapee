using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_move2 : MonoBehaviour {
	private Animator animator;
	public static bool tap;
	// Use this for initialization
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	void Tap()
	{
		if (CharacterMove.tap == true)
		{

			animator.SetBool("is_run", true);
			transform.position += transform.forward * 0.05f;

		}
		if (CharacterMove.tap == false)
		{
			animator.SetBool("is_run", false);
			transform.position += transform.forward * 0.00f;

		}
	}

}
