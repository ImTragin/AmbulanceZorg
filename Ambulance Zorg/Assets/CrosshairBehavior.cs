using UnityEngine;
using System.Collections;

public class CrosshairBehavior : MonoBehaviour {

	public Texture2D crosshairTexture;
	private Rect pos;

	// Use this for initialization
	void Start () {

		pos = new Rect((Screen.width - crosshairTexture.width) / 2, (Screen.height - crosshairTexture.height) / 2 - 25,
			crosshairTexture.width, crosshairTexture.height);

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{
		GUI.DrawTexture(pos, crosshairTexture);
	}
}
