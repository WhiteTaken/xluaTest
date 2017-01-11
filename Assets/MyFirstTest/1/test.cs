using UnityEngine;
using System.Collections;
using XLua;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LuaEnv luaenv = new LuaEnv();
		luaenv.DoString("require 'runLua'");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
