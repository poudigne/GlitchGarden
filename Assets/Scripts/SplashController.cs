using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour {

  private int delay = 3;

	// Update is called once per frame
	void Update () {
    if (Time.time > delay)
    {
      LevelManager man = GameObject.Find("LevelManager").GetComponent<LevelManager>();
      man.LoadLevel("01 Start Menu");
    }
	}
}
