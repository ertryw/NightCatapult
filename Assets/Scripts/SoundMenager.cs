using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundMenager
{
    
   public static void PlayCatapultShow()
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        if (GameObject.Find("GameAssets"))
        if (GameAssets.Instance != null)
        audioSource.PlayOneShot(GameAssets.Instance.catapultShot);
    }
    public static void PlayWoodBrake()
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        if (GameObject.Find("GameAssets"))
            if (GameAssets.Instance != null)
            audioSource.PlayOneShot(GameAssets.Instance.WoodBrake);
    }
    public static void PlayFire()
    {
        if (!GameObject.Find("SoundFire"))
        {
            GameObject soundGameObject = new GameObject("SoundFire");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.loop = true;
            if (GameObject.Find("GameAssets"))
                if (GameAssets.Instance != null)
                audioSource.PlayOneShot(GameAssets.Instance.Fire,0.5f);
        }
    }
}
