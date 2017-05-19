using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineManager : MonoBehaviour {

	public Text Object_CharText; // 캐릭터 이름을 표기하는 Text UI
	public Text Object_LineText; // 대사를 표기하는 Text UI
	public DataManager Class_DataManager; // DataManager 클래스

	public int line_Index; // 플레이어의 현재 라인
	int line_Status; // 라인 진행의 상태 (대기, 진행중, 다음 진행 대기)
	int line_Process; // 문장을 자를 때 쓸것

	void Start()
	{
		lineIndex = Playerdata_lineIndex;
	}

	public static void screenTouch() // 스크린 터치 시의 행동;
	{
		switch(Class_DataManager.Gamedata_scriptLine.Split('|')[0])
		{
			case "com":
				break;
			case "l":
				switch(lineStatus)
				{
					case 0:
						line_Process = 0;
						break;
					case 1:
						line_Process = Class_DataManager.Gamedata_scriptLine[line_Index].Split('|')[2];
						break;
					case 2:
						break;
				}
				break;
		}
	}
}
