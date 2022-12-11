using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform targetTr;
    public float dist = 10.0f;
    public float height = 3.0f;
    public float dampTrace = 20.0f;
    public float smoothRotate = 5.0f;
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float currYAngle = Mathf.Lerp(tr.eulerAngles.y, targetTr.eulerAngles.y, smoothRotate*Time.deltaTime);

        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

        tr.position = targetTr.position - (rot *Vector3.forward*dist) + (Vector3.up*height); 

        tr.LookAt(targetTr);
    }
}
