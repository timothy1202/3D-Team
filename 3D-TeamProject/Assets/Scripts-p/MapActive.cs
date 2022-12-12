using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MapActive : MonoBehaviour
{
    protected bool Mapstate;
    public GameObject MapTarget;
    // Start is called before the first frame update
    void Start()
    {
        Mapstate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MapCtrl.MapOpen == true)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (Mapstate == false)
                {
                    MapTarget.SetActive(true);
                    Mapstate = true;
                }
            }
        }
        if (UIMgrMap.MapBtOn == true)
        {
            MapTarget.SetActive(false);
            Mapstate = false;
            UIMgrMap.MapBtOn = false;
            //MapCtrl.MapOpen = false;
        }
        if(MapCtrl.MapOpen == false)
        {
            MapTarget.SetActive(false);
            Mapstate = false;
        }
    }
}
