using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : ITransport
{
    public void Deliver()
    {
        Debug.Log("envio en un caza F-35");
    }
}
