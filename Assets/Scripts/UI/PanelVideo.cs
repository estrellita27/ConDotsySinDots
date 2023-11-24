using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System.Threading;

public class PanelVideo : MonoBehaviour
{
    public VideoPlayer video;
    void Awake(){
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += FinVideo;
    }
    
    void FinVideo(VideoPlayer vd){
        SceneManager.LoadScene("PantallaSelect");
    }
}
