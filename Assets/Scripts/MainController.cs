using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {
    // Static singleton instance
    private static MainController _instance;
    public static MainController Instance { get { return _instance; } }



    void Awake()
    {
        if (_instance == null)
            _instance = this;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
