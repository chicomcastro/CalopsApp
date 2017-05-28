using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RecordingScript : MonoBehaviour {

	AudioSource aud;

	string currenteMic = "Built-in Microphone";

	void Awake () {
		aud = GetComponent<AudioSource>();
		if (System.IO.Directory.Exists (System.IO.Directory.GetCurrentDirectory () + "/ConsoleApplication/Ata0/")) {
			System.IO.Directory.Delete (System.IO.Directory.GetCurrentDirectory () + "/ConsoleApplication/Ata0/");
			System.IO.Directory.CreateDirectory (System.IO.Directory.GetCurrentDirectory () + "/ConsoleApplication/Ata0/");
		}

	}

	public void StartRecording () {
		if (!Microphone.IsRecording (currenteMic)) {
			GameObject.FindGameObjectWithTag ("Canvas").GetComponent<Animator> ().SetBool ("active", true);
			aud.clip = Microphone.Start (currenteMic, false, 30, 44100);
		}
	}

	public void StopRecording () {
		if ( Microphone.IsRecording (currenteMic) ) {
			GameObject.FindGameObjectWithTag ("Canvas").GetComponent<Animator> ().SetBool ("active", false);
			Microphone.End (currenteMic);
			GenerateDocument ();
		}
	}
	public void GenerateDocument () {
		GetComponent<GenerateAudio> ().CallSaveFunction("audio", aud.clip);
	}

	// If you want to listen to last recorded audio
	public void ListenTo () {
		if (!aud.isPlaying) {
			aud.Play ();
		} else {
			aud.Stop ();
		}
	}

	// Read generate .txt files
	public void Read () {
		System.Diagnostics.Process.Start (System.IO.Directory.GetCurrentDirectory () + "/ConsoleApplication/Ata0/");
	}

	public void ExitApplication () {
		Application.Quit();
	}
}