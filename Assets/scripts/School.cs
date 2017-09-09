using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class School : MonoBehaviour
{

	//学校ステージのスクリプト
	//アイテム管理用は下記

	public static bool MainKey = false; //ステージ脱出用の鍵（1つしかないためbool型）
	public static bool EightKey = false; //8Fアンロック用鍵（1つしかないため以下同文）

	//以下フラグ

	public static bool MainKeyAttached = false; //ステージアンロック用鍵の取得条件クリア
	public static bool EightKeyAttached = false; //8Fアンロック用鍵の取得条件クリア
	public static bool GameCompleted = false; //ステージクリアの条件クリア　ー＞　終了ワールドへ転送


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public static void SchoolMain()
	{
		Debug.Log("Schoolの呼び出しを完了");

		if (MainKeyAttached = true)
		{
			Debug.Log("メインキーを入手しました");
		}

		if (EightKeyAttached = true)
		{
			Debug.Log("8Fの鍵を入手しました");
		}

		if (EightKey = true)
		{
			Debug.Log("8Fがアンロックされました");
		}

		if (MainKey = true)
		{
			Debug.Log("ステージ脱出扉がアンロックされました");
		}
		if (GameCompleted = true)
		{
			Debug.Log("ステージはクリアされました");
			SceneManager.LoadScene("TestStage");
			transport_world.TransportComplete = 1;
		}
	}
}