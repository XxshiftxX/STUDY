using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineManager : MonoBehaviour {

	public Text Object_CharText; // 캐릭터 이름을 표기하는 Text UI
	public Text Object_LineText; // 대사를 표기하는 Text UI

	// Use this for initialization
	void Start () {
		DataManager dm = new DataManager();
		dm.scriptLoad("test");
	}

	// Update is called once per frame
	void Update () {

	}
}
