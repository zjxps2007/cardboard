using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeVideo : MonoBehaviour
{
    public VideoClip clip01;
    public VideoClip clip02;
    private bool isclip01;
    private bool isclip02;

    private VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer = gameObject.GetComponent<VideoPlayer>();
    }


    public void Change01()
    {
        if (!isclip01)
        {
            videoPlayer.clip = clip01;
            isclip01 = true;
            isclip02 = false;
        }
        else
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
            }
        }
    }

    public void Change02()
    {
        if (!isclip02)
        {
            videoPlayer.clip = clip02;
            isclip02 = true;
            isclip01 = false;
        }
        else
        {
            if (videoPlayer.isPlaying)
            {
                gameObject.GetComponent<VideoPlayer>().Pause();
            }
            else
            {
                gameObject.GetComponent<VideoPlayer>().Play();
            }
        }
    }
}
