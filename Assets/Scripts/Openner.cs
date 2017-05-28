using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System;

public class Openner : MonoBehaviour {
    
    // Use this for initialization
    public void Decode()
    {
		// Tenho que dar um jeito de fazer esse cara abrir dentro da pasta assets
		Process.Start(System.IO.Directory.GetCurrentDirectory() + "/ConsoleApplication/ConsoleApplication1.exe");
    }
}
