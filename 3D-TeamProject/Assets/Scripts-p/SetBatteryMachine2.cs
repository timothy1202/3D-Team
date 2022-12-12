using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBatteryMachine2 : MonoBehaviour
{
    protected bool state;
    public GameObject BatteryTarget2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BatteryMachine.CameToBatteryMachine == true)
        {
            if (SetActiveBatteryMachine.BatteryCount == 1)
            {

            if (Input.GetKeyDown(KeyCode.F))
            {
                SetActiveBatteryMachine.BatteryCount++;
                Debug.Log("배터리를" + SetActiveBatteryMachine. BatteryCount + "개 넣어 주었습니다!");
                BatteryTarget2.SetActive(true);
                BatteryMachine.CameToBatteryMachine = false;
            }
            }   

        }
    }
}
