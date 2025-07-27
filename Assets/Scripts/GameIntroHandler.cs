using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class GameIntroHandler : MonoBehaviour
{
    [Header("Intro сameras")]
    [SerializeField] CinemachineCamera[] cameras;

    [Header("Transitions settings")]
    [SerializeField] float cameraTransitionDelay = 0.5f;
    [SerializeField] CinemachineBrain cinemachineBrain;

    void Start()
    {
        StartCoroutine(ShowIntro());
    }

    IEnumerator ShowIntro()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            SwitchToCamera(cameras[i]);
            yield return new WaitForSeconds(cinemachineBrain.DefaultBlend.Time + cameraTransitionDelay);
        }
    }

    private void SwitchToCamera(CinemachineCamera camera)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].Priority = cameras[i] == camera ? 10 : 1;
        }
    }
}
