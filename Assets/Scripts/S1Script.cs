using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S1Script : MonoBehaviour {
	public string levelToLoad = "s2";

	public SceneFader sceneFader;

	public void GotoS2 ()
	{
		sceneFader.FadeTo(levelToLoad);
	}

}
