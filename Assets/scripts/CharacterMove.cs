using UnityEngine;
using System.Collections;


public class CharacterMove : MonoBehaviour
{
	private Animator animator;
	public static bool tap;
	// Use this for initialization
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			transform.position += transform.forward * 0.05f;
			animator.SetBool("is_run", true);
		}
		else
		{
			animator.SetBool("is_run", false);
		}
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began && GameMainController.MoveStop == false)
			{
				//tap = true;
				transform.position += transform.forward * 0.05f;
				animator.SetBool("is_run", true);

			}
			if (touch.phase == TouchPhase.Stationary)
			{
				transform.position += transform.forward * 0.05f;
				animator.SetBool("is_run", true);
			}
			if (touch.phase == TouchPhase.Moved)
			{
				transform.position += transform.forward * 0.05f;
				animator.SetBool("is_run", true);
			}
			if (touch.phase == TouchPhase.Ended)
			{
				//tap = false;
				transform.position += transform.forward * 0.00f;
				animator.SetBool("is_run", false);
			}
		}
		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.y = Input.acceleration.y;
		//float dir = Input.acceleration.y;

		if (dir.sqrMagnitude > 1)
		{
			dir.Normalize();
		}

		if (Input.acceleration.x > 0.1f && GameMainController.MoveStop == false)
		{
			//transform.rotation.y += 1.0f;
			transform.Rotate(0, 2, 0);
		}
		if (Input.acceleration.x < -0.1f && GameMainController.MoveStop == false)
		{
			transform.Rotate(0, -2, 0);
		}
		if (Input.GetKey(KeyCode.D) && GameMainController.MoveStop == false)
		{
			transform.Rotate(0, 2, 0);
			//Debug.Log("移動処理は完了している");
		}
		if (Input.GetKey(KeyCode.A) && GameMainController.MoveStop == false)
		{
			transform.Rotate(0, -2, 0);
			//Debug.Log("移動処理は完了している");
		}

	}
}
