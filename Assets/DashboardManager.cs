using UnityEngine;

public class DashboardManager : MonoBehaviour
{
    public GameObject dashboardUI;
    public GameObject solarSystemScene;
    public GameObject creationVideoPanel;

    public void StartVRTour()
    {
        dashboardUI.SetActive(false);
        solarSystemScene.SetActive(true);
    }

    public void PlayCreationVideo()
    {
        dashboardUI.SetActive(false);
        creationVideoPanel.SetActive(true);
    }
}
