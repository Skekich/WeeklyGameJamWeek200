using UnityEngine;
using System;

public class AudioCue : MonoBehaviour
{
    [SerializeField] private SoundSO[] sound;
    [SerializeField] private SoundSO mainTheme;

    private void Awake() {
        foreach(SoundSO currentSound in sound) {
            currentSound.source = gameObject.AddComponent<AudioSource>();
            currentSound.source.clip = currentSound.clip;
            currentSound.source.volume = currentSound.volume;
            currentSound.source.pitch = currentSound.pitch;
            currentSound.source.loop = currentSound.loop;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start() {
        PlayAudio(mainTheme);
    }

    public void PlayAudio(SoundSO soundToPlay){
        SoundSO soundSelected = Array.Find(sound, sound => sound.name == soundToPlay.name);
        soundSelected.source.Play();
    }
}
