using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Video : MonoBehaviour
{
    [Tooltip("This is the TextReader script component.")]
    public TextReader textReader;
    [Tooltip("This is the play button's material.")]
    public Material playButtonMaterial;
    [Tooltip("This is the pause button's material.")]
    public Material pauseButtonMaterial;
    [Tooltip("This is the replay button's material.")]
    public Material replayButtonMaterial;
    [Tooltip("This is the renderer component for the play button.")]
    public Renderer playButtonRenderer;
    [Tooltip("This is the array for your video clips that will be played in the scene.")]
    public VideoClip[] videoClips;

    public GameObject previousButton;
    public GameObject nextButton;
    protected double currentTime;
    protected double totalTime;

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
        previousButton.SetActive(false);
        totalTime = videoPlayer.frameCount-1;
    }

    void Update()
    {
        if(videoPlayer.isPlaying)
        {
            currentTime = videoPlayer.frame;
        }
        if(videoPlayer.isPaused && (currentTime == totalTime))
        {
            playButtonRenderer.material = replayButtonMaterial;
        }
    }

    public void NextClip()
    {
        videoClipIndex++;
        if(videoClipIndex > videoClips.Length-1)
        {
            videoClipIndex = videoClips.Length-1;
        }
        videoPlayer.clip = videoClips[videoClipIndex];
        totalTime = videoPlayer.frameCount-1;
        textReader.NextStep();
        videoPlayer.Play();
        ToggleButtonVisibility();

    }

    public void PreviousClip()
    {
        videoClipIndex--;
        if (videoClipIndex < 0)
        {
            videoClipIndex = 0;
        }
        videoPlayer.clip = videoClips[videoClipIndex];
        totalTime = videoPlayer.frameCount-1;
        textReader.PreviousStep();
        videoPlayer.Play();
        ToggleButtonVisibility();
    }

    public void PlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playButtonRenderer.material = playButtonMaterial;
            return;
        }
        else
        {
            videoPlayer.Play();
            playButtonRenderer.material = pauseButtonMaterial;
        }
    }

    public void ToggleButtonVisibility()
    {
        if (videoClipIndex > 0)
        {
            previousButton.SetActive(true);
        }
        else
        {
            previousButton.SetActive(false);
        }
        if (videoClipIndex == videoClips.Length - 1)
        {
            nextButton.SetActive(false);
        }
        else
        {
            nextButton.SetActive(true);
        }
    }
}
