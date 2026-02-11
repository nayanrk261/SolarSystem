using UnityEngine;
using UnityEngine.Video;

public class DashboardController : MonoBehaviour
{
    public GameObject dashboardUI;
    public GameObject videoScreen;
    public VideoPlayer videoPlayer;

    // Called when "How Solar System Was Created" button is clicked
    public void PlayCreationVideo()
    {
        dashboardUI.SetActive(false);
        videoScreen.SetActive(true);
        videoPlayer.Play();
    }

    // Called when "VR Tour" button is clicked
    public void StartVRTour()
    {
        dashboardUI.SetActive(false);
        // Later we will add camera movement here
        Debug.Log("VR Tour Started");
    }

    // Called when "Quiz" button is clicked
    public void OpenQuiz()
    {
        Debug.Log("Quiz clicked");
    }
}
