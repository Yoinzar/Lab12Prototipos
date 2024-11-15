using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : ITransport
{
    public void Deliver()
    {
        Debug.Log("envio por titanic");
    }
}
