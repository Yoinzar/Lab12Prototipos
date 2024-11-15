using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : ITransport
{
    public void Deliver()
    {
        Debug.Log("envio por camion");
    }
}
