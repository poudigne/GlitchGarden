﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

  public AudioClip[] levelMusicChangeArray;


  private AudioSource audioSource;
	// Use this for initialization
	void Awake() {
    DontDestroyOnLoad(gameObject);
    Debug.Log("Don't destroy on load : " + name);
	}

  void Start()
  {
    audioSource = GetComponent<AudioSource>();
  }

  void OnLevelWasLoaded(int level)
  {
    AudioClip thisLevelMusic = levelMusicChangeArray[level];
    Debug.Log("Playing clip : " + thisLevelMusic);

    if (thisLevelMusic) // if there's some music
    {
      audioSource.clip = thisLevelMusic;
      audioSource.loop = true;
      audioSource.Play();
    }
  }

  public void ChangeVolume(float volume)
  {
    if (volume >= 0f && volume <= 1.0f)
    {
      audioSource.volume = volume;
    }
    else
    {
      Debug.LogError("Trying to change volume to an incorrect value");
    }
  }
}
