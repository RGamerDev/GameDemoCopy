using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
[RequireComponent(typeof(AudioSource))]
public class PauseAndPlayTexture : MonoBehaviour
{
    public VideoClip VideoClip;
    private VideoPlayer VideoPlayer;
    private AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer = GetComponent<VideoPlayer>();
        AudioSource = GetComponent<AudioSource>();

        //disable Play on Awake for both video and audio
        VideoPlayer.playOnAwake = false;
        AudioSource.playOnAwake = false;

        //assign video clip
        VideoPlayer.source = VideoSource.VideoClip;
        VideoPlayer.clip = VideoClip;

        //setup audio source
        VideoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        VideoPlayer.SetTargetAudioSource(0, AudioSource);

        //render video to main texture of parent GameObject
        VideoPlayer.renderMode = VideoRenderMode.MaterialOverride;
        VideoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        VideoPlayer.targetMaterialProperty = "_MainTex";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (VideoPlayer.isPlaying)
            {
                VideoPlayer.Pause();
                AudioSource.Pause();
            }
            else
            {
                VideoPlayer.Play();
                AudioSource.Play();
            }
        }
    }
}
