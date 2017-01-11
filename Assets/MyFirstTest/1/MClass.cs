using UnityEngine;
using System.Collections;
using XLua;

[XLua.CSharpCallLua]
public struct parma{
	public int x;
	public int y;
}

[XLua.CSharpCallLua]
public delegate void SetIntDelegate(int i);

[CSharpCallLua]
public interface ins{
	int a{ get; set;}
	int b{ get; set;}
}

[XLua.LuaCallCSharp]
public class MClass {
	public void Test(){
		Debug.Log ("我是lua调用的方法");
	}

	public void SetParma(parma test,SetIntDelegate fuction,ins test2)
	{
		Debug.Log ("CSharp test.x=" + test.x);
		fuction (1);
		test2.a= 10;
	}
}
