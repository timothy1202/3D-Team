using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActivePlug : MonoBehaviour
{
    protected bool state;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (UIMgrPiug.PlugBtOn == true)
        {
            Target.SetActive(true);
            state = false;
            UIMgrPiug.PlugBtOn = false;
        }
    }
}
