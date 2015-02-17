using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

  const string MASTER_VOLUME_KEY = "master_volume";
  const string DIFFICULTY_KEY = "difficulty";
  const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume(float volume) {
    if (volume >= 0f && volume <= 1.0f)
      PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
    else
      Debug.LogError("Master volume out of range");
  }

  public static float GetMasterVolume(){
    return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
  }

  public static void UnlockLevel(int level)
  {
    if (level <= Application.levelCount - 1)
      PlayerPrefs.SetInt(LEVEL_KEY + level, 1);
    else
      Debug.LogError("Trying to unlock level not in build order");
  }

  public static bool GetUnlockLevel(int level)
  {
    if (level <= Application.levelCount - 1)
     return PlayerPrefs.GetInt(LEVEL_KEY + level) == 1;
    return false;
  }

  public static void SetDifficulty(int difficulty)
  {
    if (difficulty >= 1 && difficulty <= 3)
    {
      PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);
    }
    else
    {
      Debug.LogError("Trying to set inccorect difficulty value");
    }
  }

  public static int GetDifficulty()
  {
    return PlayerPrefs.GetInt(DIFFICULTY_KEY);
  }
}
