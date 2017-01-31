using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public Vector3 m_vecDirection;
    public float m_fVelocity;

    private SpriteRenderer m_Sprite;
    private bool m_bIsDirLockX;
    private bool m_bIsDirLockY;

    // Use this for initialization
    void Start () {
        m_Sprite = this.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(m_vecDirection.normalized * m_fVelocity * Time.deltaTime);
        CheckEdge();
	}

    private void CheckEdge()
    {
        Camera mainCamera = Camera.main;
        Vector3 _ballScreenPos = mainCamera.WorldToViewportPoint(this.transform.position);
        // X-Axis check
        if(_ballScreenPos.x < 0.0f || _ballScreenPos.x > 1.0f)
        {
            if (!m_bIsDirLockX)
            {
                m_vecDirection.x *= -1;
                m_bIsDirLockX = true;
            }
        }
        if (_ballScreenPos.x >= 0.2f && _ballScreenPos.x <= 0.8f)
            m_bIsDirLockX = false;

        // Y-Axis check
        if (_ballScreenPos.y < 0.0 || _ballScreenPos.y > 1.0)
        {
            if (!m_bIsDirLockY)
            {
                m_vecDirection.y *= -1;
                m_bIsDirLockY = true;
            }
        }
        if (_ballScreenPos.y >= 0.2f && _ballScreenPos.y <= 0.8f)
            m_bIsDirLockY = false;
    }
}
