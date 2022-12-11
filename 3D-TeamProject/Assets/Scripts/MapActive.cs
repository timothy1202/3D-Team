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
                Debug.Log("키 입력 받았음");
                if (Mapstate == false)
                {
                    MapTarget.SetActive(true);
                    Debug.Log("맵 생겨나");
                    Mapstate = true;
                    MapCtrl.MapOpen = false;
                }
            }
        }
        if (UIMgrMap.MapBtOn == true)
        {
            MapTarget.SetActive(false);
            Debug.Log("맵 사라져");
            Mapstate = false;
            UIMgrMap.MapBtOn = false;
            MapCtrl.MapOpen = false;
        }
    }
}
