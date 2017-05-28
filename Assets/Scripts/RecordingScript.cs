using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordingScript : MonoBehaviour {

	AudioSource aud;

	void Awake () {
		aud = GetComponent<AudioSource>();
	}

	public void StartRecording () {
		aud.clip = Microphone.Start("Built-in Microphone", false, 10, 44100);
	}

	public void StopRecording () {

		Microphone.End("Built-in Microphone");

		GetComponent<GenerateAudio> ().CallSaveFunction("audio", aud.clip);
	}

	public void ListenTo () {
		aud.Play ();
	}

	public void ExitApplication () {
		Application.Quit();
	}
}