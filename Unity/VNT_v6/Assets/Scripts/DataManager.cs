using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임에서 쓰이는 데이터 관리
public class DataManager : MonoBehaviour {

	public int Playerdata_pageIndex; // 플레이어가 실행했던 페이지(스크립트 파일)
	public int Playerdata_lineIndex; // 플레이어가 실행했던 라인

	public string[] Gamedata_scriptLine; // 게임의 스크립트의 라인이 들어갈 변수

	public TextAsset[] Assetdata_scripts; // 스크립트 파일들이 들어갈 변수

	// 특정 스크립트를 로드하여 Gamedata_scriptLine에 넣음 (script : 로드할 스크립트)
	public void scriptLoad(string script){
		Gamedata_scriptLine = script.Split('\n');
	}

	void Start()
	{
		scriptLoad(Assetdata_scripts[0].text);
	}
}
