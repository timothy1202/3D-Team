using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWire : MonoBehaviour
{ 
    [SerializeField]
    private RectTransform mWirebBody;
    private LeftWire mSelecteWire;

    [SerializeField]
    private float offset = 15f;
    private Canvas mGameCanvas;

// Start is called before the first frame update
    void Start()
    {
    mGameCanvas = FindObjectOfType<Canvas>();
    }

// Update is called once per frame
    void Update()
    {
    if (Input.GetMouseButton(0))
    {
        RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.right, 1f);
        if (hit.collider != null)
        {
            var left = hit.collider.GetComponentInParent<LeftWire>();
            if (left != null)
            {
                mSelecteWire = left;
            }
        }
    }

    if (Input.GetMouseButtonUp(0))
    {
        if (mSelecteWire != null)
        {
            mWirebBody.localRotation = Quaternion.Euler(Vector3.zero);
            mWirebBody.sizeDelta = new Vector2(0f, mWirebBody.sizeDelta.y);
            mSelecteWire = null;
        }
    }

    if (mSelecteWire != null)
    {
        float angle = Vector2.SignedAngle(transform.position + Vector3.right - transform.position,
            Input.mousePosition - transform.position);
        float distance = (Vector2.Distance(mWirebBody.transform.position, Input.mousePosition) - offset);
        mWirebBody.localRotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        mWirebBody.sizeDelta = new Vector2(distance * (1 / mGameCanvas.transform.localScale.x), mWirebBody.sizeDelta.y);
    }
    }
}
