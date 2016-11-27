using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class AudioManager : MonoBehaviour
    {
        private bool isPlaying = false;
        private AudioClip audio;
        private AudioSource audioSource;
        void Awake()
        {

        }
        void Start()
        {

        }

        private AudioClip getAudio(string audioPath)
        {
            return null;
        }
        public void PlayAudio(string audioPath)
        {
            audioSource.Play(getAudio(audioPath));
            audioSource.Play();
            isPlaying = true;

        }
        public void PauseAudio()
        {
            audioSource.Pause();
            isPlaying = false;
        }
        public void StopAudio()
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }
}
