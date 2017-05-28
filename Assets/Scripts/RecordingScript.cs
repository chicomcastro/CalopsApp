using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordingScript : MonoBehaviour {

	AudioSource aud;

	string currenteMic = "Built-in Microphone";

	void Awake () {
		aud = GetComponent<AudioSource>();
	}

	public void StartRecording () {
		if (!Microphone.IsRecording (currenteMic)) {
			aud.clip = Microphone.Start (currenteMic, false, 30, 44100);
		} else {
			Microphone.End (currenteMic);
			GenerateDocument ();
		}
	}

	public void GenerateDocument () {
		GetComponent<GenerateAudio> ().CallSaveFunction("audio", aud.clip);
	}

	public void ListenTo () {
		if (!aud.isPlaying) {
			aud.Play ();
		} else {
			aud.Stop ();
		}
	}

	public void ExitApplication () {
		Application.Quit();
	}
}