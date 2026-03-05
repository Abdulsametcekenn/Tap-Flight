using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public VideoPlayer video;

    void Start()
    {
        video.loopPointReached += EndVideo;
    }

    void EndVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene("SampleScene");
    }
}