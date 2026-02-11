using UnityEngine;

public class DashboardController : MonoBehaviour
{
    public GameObject dashboardUI;
    public GameObject solarSystemScene;

    public void StartVRTour()
    {
        dashboardUI.SetActive(false);
        solarSystemScene.SetActive(true);
    }
}
