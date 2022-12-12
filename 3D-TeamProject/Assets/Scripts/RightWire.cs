using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightWire : MonoBehaviour
{
    public EWireNum WireNum { get; private set; }

    public bool IsConnected { get; private set; }

    private List<LeftWire> mConnectedWires =new List<LeftWire>();

 public void ConnectWire(LeftWire leftwire)
    {
        if (mConnectedWires.Contains(leftwire))
        {
            return;
        }
        mConnectedWires.Add(leftwire);
        if(mConnectedWires.Count ==1 && leftwire.WireNum== WireNum)
        {
            IsConnected= true;
        }
        else
        {
            IsConnected= false;
        }
    }
    public void DisconnectWire(LeftWire leftwire)
    {
        mConnectedWires.Remove(leftwire);
        if(mConnectedWires.Count ==1 && mConnectedWires[0].WireNum == WireNum)
        {
            IsConnected = true;
        }
        else
        {
            IsConnected= false;
        }
    }
}
