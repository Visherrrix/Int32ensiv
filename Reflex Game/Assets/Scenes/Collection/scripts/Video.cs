using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    

    void Start()
    {
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        StartCoroutine(LoadSceneAfterVideo());
    }

    IEnumerator LoadSceneAfterVideo()
    {
        yield return new WaitForSeconds(1/2); // ���� 1 ������� ����� ��������� �����
        SceneManager.LoadScene(1);
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
    }
}
