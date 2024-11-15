using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}
