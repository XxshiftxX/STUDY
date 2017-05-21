using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineManager : MonoBehaviour {

	public Text Object_CharText; // 캐릭터 이름을 표기하는 Text UI
	public Text Object_LineText; // 대사를 표기하는 Text UI
	public DataManager Class_DataManager; // DataManager 클래스

	public int line_Index; // 플레이어의 현재 라인 번호
	public int line_Status; // 라인 진행의 상태 (대기, 진행중, 다음 진행 대기)
	public int line_Process; // 문장을 자를 때 쓸것
	string line_String;
	string line_DisplayString;

	void Start()
	{
		line_Index = Class_DataManager.Playerdata_lineIndex;
	}

	public void screenTouch() // 스크린 터치 시의 행동;
	{
		switch(Class_DataManager.Gamedata_scriptLine[line_Index].Split('|')[0])
		{
		case "com":
			break;
		case "l":
			switch(line_Status)
			{
			case 0:
				line_String = Class_DataManager.Gamedata_scriptLine [line_Index].Split ('|') [1];
				line_Status = 1;
				line_Process = 0;
				StartCoroutine ("line_Timer");
				break;
			case 1:
				line_Status = 2;
				line_Process = line_String.Length;
				break;
			case 2:
				line_Status = 0;
				line_DisplayString = "";
				screenTouch ();
				break;
			}
		break;
		}
	}

	IEnumerator line_Timer(){
		if (line_Process < line_String.Length-1) {
			line_DisplayString = line_String.Remove (line_Process);
			Object_LineText.text = line_DisplayString;
			line_Process++;
		} else {
			line_Status = 2;
			Object_LineText.text = line_String;
		}

		yield return new WaitForSeconds (0.02f);

		if (line_Status != 2)
			StartCoroutine ("line_Timer");
		else
			line_Status = 2;
	}
}
