using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Video : MonoBehaviour
{
    public TextReader textReader;
    public Material playButtonMaterial;
    public Material pauseButtonMaterial;
    public Renderer playButtonRenderer;
    public VideoClip[] videoClips;
    public double currentSeconds;
    public double totalSeconds;

    private int videoClipIndex;
    private VideoPlayer videoPlayer;


    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        videoPlayer.targetTexture.Release();
        videoPlayer.clip = videoClips[0];
        totalSeconds = videoPlayer.clip.length;
    }

    public void NextClip()
    {
        videoClipIndex++;
        if(videoClipIndex > videoClips.Length-1)
        {
            videoClipIndex = videoClips.Length-1;
        }
        videoPlayer.clip = videoClips[videoClipIndex];
        textReader.NextStep();
        videoPlayer.Play();
    }

    public void PreviousClip()
    {
        videoClipIndex--;
        if (videoClipIndex < 0)
        {
            videoClipIndex = 0;
        }
        videoPlayer.clip = videoClips[videoClipIndex];
        textReader.PreviousStep();
        videoPlayer.Play();
    }

    public void PlayPause()
    {
        if(videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playButtonRenderer.material = playButtonMaterial;
        }
        else
        {
            videoPlayer.Play();
            playButtonRenderer.material = pauseButtonMaterial;
        }
    }
}
