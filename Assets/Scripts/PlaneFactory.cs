using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Plane();
    }
}
