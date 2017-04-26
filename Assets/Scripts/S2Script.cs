using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S2Script : MonoBehaviour {
	public string levelToLoad = "s1";

	public SceneFader sceneFader;

	public void GotoS1 ()
	{
		sceneFader.FadeTo(levelToLoad);
	}

}
