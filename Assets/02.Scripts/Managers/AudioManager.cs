using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Transform effects;
    public Transform bgms;

    public AudioSource[] effectList;
    public AudioSource[] bgmList;

    Dictionary<string, int> dicEffect = new Dictionary<string, int>();
    Dictionary<string, int> dicBGM = new Dictionary<string, int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        InitAudioManager();
    }

    void InitAudioManager()
    {
        effectList = effects.GetComponentsInChildren<AudioSource>();
        bgmList = bgms.GetComponentsInChildren<AudioSource>();

        for (int i = 0; i < effectList.Length; i++)
        {
            dicEffect.Add(effectList[i].gameObject.name, i);
        }

        for(int i = 0; i < bgmList.Length; i++)
        {
            dicEffect.Add(bgmList[i].gameObject.name, i);
        }
    }

    public void PlayEffectAudio(string tag)
    {
        int i;

        if(dicEffect.TryGetValue(tag, out i))
        {
            effectList[i].Play();
        }
        else
        {
            Debug.Log("No Effect Audio Name " + tag);
        }
    }

    public void PlayBGMAudio(string tag)
    {
        int i;

        if (dicEffect.TryGetValue(tag, out i))
        {
            bgmList[i].Play();
        }
        else
        {
            Debug.Log("No BGM Audio Name " + tag);
        }
    }

    public void StopBGMAudio(string tag)
    {
        int i;

        if (dicEffect.TryGetValue(tag, out i))
        {
            bgmList[i].Stop();
        }
        else
        {
            Debug.Log("No BGM Audio Name " + tag);
        }
    }

    public void StopAllBGMAudio()
    {
        foreach(AudioSource audio in bgmList)
        {
            audio.Stop();
        }
    }

    public void StopAllEffectAudio()
    {
        foreach (AudioSource audio in effectList)
        {
            audio.Stop();
        }
    }
}
