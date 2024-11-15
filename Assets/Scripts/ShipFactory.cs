using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
