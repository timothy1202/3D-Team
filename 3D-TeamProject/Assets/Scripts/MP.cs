using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MP : MonoBehaviour
{
    [SerializeField]
    private Slider mpbar;

    private float maxmp = 100;
    private float curmp = 100;

    // Start is called before the first frame update
    void Start()
    {
        mpbar.value = (float)curmp / (float)maxmp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            curmp -= 10;
        }
        HandleMP();
    }

    private void HandleMP()
    {
        mpbar.value = (float)curmp / (float)maxmp;
    }
}
