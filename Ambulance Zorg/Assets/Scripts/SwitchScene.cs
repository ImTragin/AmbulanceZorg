using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	// Use this for initialization
	public void SceneSwitch (int indexNr) {

        SceneManager.LoadScene(indexNr);
	}
	
}
