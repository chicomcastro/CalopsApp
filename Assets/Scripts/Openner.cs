using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System;

public class Openner : MonoBehaviour {
    
    // Use this for initialization
    public void Decode()
    {
		UnityEngine.Debug.Log ("Estou rodando"); 

		// Tenho que dar um jeito de fazer esse cara abrir dentro da pasta assets
		Process.Start(Application.dataPath + "/ConsoleApplication1.exe");
    }
}
