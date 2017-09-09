using UnityEngine;
using System.Collections;
using Utage;

public class GameMainController : MonoBehaviour
{

	public static bool gamestarted;
	public static bool GetTransport;
	public static int Ikisaki;
	public static bool moji;
	public static bool TransportToWorld;
	public static bool MoveStop;
	public AdvEngine engine;
	public string scenarioLabel;

    // Use this for initialization
    void Start()
	{
		MoveStop = true;
		StartCoroutine(CoTalk());
		gamestarted = true;
		Invoke("m_move", 1.0f);
	}

	IEnumerator CoTalk()
	{
		engine.JumpScenario(scenarioLabel);

		while (!engine.IsEndScenario)
		{
			yield return 0;
		}
        if (engine.IsEndScenario) {
            MoveStop = false;
        }
	}

	// Update is called once per frame
	void Update()
	{
	}

	void m_move()
	{
		moji = true;
	}

	public static void TransportToSchool()
	{
		Ikisaki = 2;
		if (transport_world.TransportComplete == 1)
		{
			School.SchoolMain();
		}
		transport_world.TransportComplete = 0;
	}

	public static void SaveData()
	{
		Debug.Log("データをセーブします");
		Debug.Log("セーブ対象は");
		Debug.Log("獲得アイテム、ワールドのクリア有無");
		Debug.Log("です");
		//データのセーブスクリプトを呼び出し
	}
}
