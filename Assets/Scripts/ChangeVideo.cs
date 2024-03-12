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
    
    
    public void Change01()
    {
        if (!isclip01)
        {
            gameObject.GetComponent<VideoPlayer>().clip = clip01;
            isclip01 = true;
        }
    }

    public void Change02()
    {
        if (!isclip02)
        {
            gameObject.GetComponent<VideoPlayer>().clip = clip02;
            isclip02 = true;
        }
    }
}
