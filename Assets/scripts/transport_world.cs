using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class transport_world : MonoBehaviour {

	public static int TransportComplete = 0;

	// Use this for initialization
	void Start()
	{
	}

    private void transportScene()
    {
        switch (GameMainController.Ikisaki)
        {
            case 1:
                Invoke("transportTo1F", 0.01f);
                break;
            case 8:
                Invoke("transportTo8F", 0.01f);
                break;
            case 2:
                Invoke("transportTo2F", 0.01f);
                break;
        }
    }
    
    public static void transportTo1F() //1階への遷移（外部での呼び出しを想定して、グローバル関数で記述）
    {
        SceneManager.LoadScene("School_first_floor");
		transport_world.TransportComplete = 1;
    }
    public static void transportTo8F() //8階への遷移（外部での呼び出しを想定して、グローバル関数で記述）
    {
        SceneManager.LoadScene("School_8th_floor");
		transport_world.TransportComplete = 1;
    }
    public static void transportTo2F() //2階への遷移（外部での呼び出しを想定して、グローバル関数で記述）
    {
        SceneManager.LoadScene("School_second_floor");
		transport_world.TransportComplete = 1;
    }
}
