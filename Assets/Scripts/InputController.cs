using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
    public GameObject CirclePref;

    private RaycastHit hit;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MouseClickDetect();
    }

    private void MouseClickDetect()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 wPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mouseClick = new Vector3(wPosition.x, wPosition.y);
            MouseClick(mouseClick);
        }
    }

    private void MouseClick(Vector2 clickPos)
    {

    }
}
