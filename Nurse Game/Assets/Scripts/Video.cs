using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Video : MonoBehaviour
{
    public Material playButtonMaterial;
    public Material pauseButtonMaterial;
    public Renderer playButtonRenderer;
    public VideoClip[] videoClips;
    private int videoClipIndex;
    private VideoPlayer videoPlayer;
    public Text currentMinutes;
    public Text currentSeconds;
    public Text totalMinutes;
    public Text totalSeconds;


    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        videoPlayer.targetTexture.Release();
        videoPlayer.clip = videoClips[0];
    }

    void Update()
    {
        /*if(videoPlayer.isPlaying)
        {
            SetCurrentTimeUI();
        }*/

    }

    public void NextClip()
    {
        videoClipIndex++;
        if(videoClipIndex >= 2)
        {
            videoClipIndex = 2;
        }

        videoPlayer.clip = videoClips[videoClipIndex];
        //SetTotalTimeUI();
        videoPlayer.Play();
    }

    public void PreviousClip()
    {
        videoClipIndex--;
        if (videoClipIndex <= 0)
        {
            videoClipIndex = 0;
        }

        videoPlayer.clip = videoClips[videoClipIndex];
        //SetTotalTimeUI();
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
            //SetTotalTimeUI();
            playButtonRenderer.material = pauseButtonMaterial;
        }
    }

    public void Replay()
    {
        if(currentMinutes == totalMinutes && currentSeconds == totalSeconds)
        {

        }
    }

    void SetCurrentTimeUI()
    {
        string minutes = Mathf.Floor((int)videoPlayer.time / 60).ToString("00");
        string seconds = ((int)videoPlayer.time % 60).ToString("00");
        currentMinutes.text = minutes;
        currentSeconds.text = seconds;
    }

    void SetTotalTimeUI()
    {
        string minutes = Mathf.Floor((int)videoPlayer.clip.length / 60).ToString("00");
        string seconds = ((int)videoPlayer.clip.length % 60).ToString("00");
        totalMinutes.text = minutes;
        totalSeconds.text = seconds;
    }
}
