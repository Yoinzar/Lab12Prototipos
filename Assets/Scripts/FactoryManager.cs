using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryManager : MonoBehaviour
{
    void Start()
    {
        CallFactory(new TruckFactory());
        CallFactory(new ShipFactory());
        CallFactory(new PlaneFactory());
    }

    private void CallFactory(TransportFactory factory)
    {
        ITransport transport = factory.CreateTransport();
        transport.Deliver();
    }
}
