using UnityEngine;
using System.Collections;

public class ToolBehavior : MonoBehaviour {

    public NurseBehavior nurse;
    private Renderer render;

    //Giving color to the placeholder
    public float color;
    public float color_2;
    public float color_3;
    public float color_4;

    // Use this for initialization
    void Start () {

        render = GetComponent<Renderer>();

        render.material.color = new Color(color, color_2, color_3, color_4);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        nurse.itemUsing = gameObject; 
    }
}
