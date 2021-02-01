﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioControler : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    public void SetVolume(float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
    }
}
