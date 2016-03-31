//----------------------------------------------------------------

// Copyright (C) 2004 北京崇佳信息科技有限公司版权所有。

// 文件名： 增强现实

// 文件功能描述： 上色App

//

//

// 创建标识：（作者日期等）2016.3.28

// 修改标识：1.0

// 修改描述：原始版本

// 修改标识：

// 修改描述：

//----------------------------------------------------------------


using UnityEngine;
using System.Collections;

public class BtnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine ("init");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator init()
	{
		show = "Click";

		GameObject btn = GameObject.Find ("UI Root/Camera/Anchor/BtnControl/Button");

		UIEventListener.Get (btn).onClick += btn_Click;

		yield return null;
	}

	string show;
	void btn_Click (GameObject go)
	{
		Debug.Log (go.name+" onclick &&&&&");
		if (show == "Click") 
		{
			show = "Clicked";
		} 
		else
		{
			show = "Click";
		}
		go.GetComponentInChildren<UILabel>().text=show;
	}
}
