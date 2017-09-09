using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mojimove : MonoBehaviour
{
	static int move_flag = 0; //文字の動作モード
	float speed = 0.1f; //横の文字の移動速度定義
	float t_speed = 0.1f; //縦の文字の移動速度定義
	public bool movestart;
	void Start()
	{
	}

	private void Update()
	{
		if (GameMainController.moji = true)
		{
			moji_ugoki();
		}

	}


	private void moji_ugoki()
	{
		if (movestart = true)
		{
			switch (move_flag)
			{
				case 0:
					gameObject.transform.position += new Vector3(0f, -t_speed, 0f);
					t_speed += 0.01f;

					if (gameObject.transform.position.y <= 10.0f)
					{
						move_flag = 1;
					}
					break;
				case 1:
					/*   gameObject.transform.position += new Vector3(0f, 0.0f, -speed);
                       speed += 0.03f;
                       if (gameObject.transform.position.z <= -25.0f)
                       {
                           move_flag = 2;  ->yokougoki関数で定義
                       }*/
					Invoke("yokougoki", 0.7f);
					break;
				case 2:
					GameMainController.moji = false;
					break;
			}
		}
	}

	void yokougoki()
	{
		gameObject.transform.position += new Vector3(0f, 0.0f, -speed);
		speed += 0.03f;
		if (gameObject.transform.position.z <= -25.0f)
		{
			move_flag = 2;
		}
	}



}