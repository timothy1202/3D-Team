using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveBatteryMachine : MonoBehaviour
{
    static public int BatteryCount = 0;
    protected bool state;
    public GameObject BatteryTarget;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BatteryMachine.CameToBatteryMachine == true)
        {
            if (BatteryCount== 0)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    BatteryCount++;
                    Debug.Log("���͸���" + BatteryCount + "�� �־� �־����ϴ�!");
                    BatteryTarget.SetActive(true);
                    BatteryMachine.CameToBatteryMachine = false;
                }
            }

        }
    }
}
