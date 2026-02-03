using UnityEngine;

public class PlanetAudio : MonoBehaviour
{
    public AudioClip planetClip;
    private AudioSource audioSource;
    private Camera mainCam;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0f;

        mainCam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    if (planetClip != null && !audioSource.isPlaying)
                    {
                        audioSource.PlayOneShot(planetClip);
                    }
                }
            }
        }
    }
}
