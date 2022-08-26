using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;

    private CinemachineVirtualCamera cinemachineVC;
    // Start is called before the first frame update

    private void Awake()
    {

        Camera.main.gameObject.TryGetComponent<CinemachineBrain>(out var brain);
        if (brain == null)
        {
            brain = Camera.main.gameObject.AddComponent<CinemachineBrain>();
        }

        cinemachineVC = GetComponent<CinemachineVirtualCamera>();
       

    }
    void Start()
    {

        playerTransform = FindObjectOfType<PlayerBehaviour>().transform;

        cinemachineVC.Follow = playerTransform;
        cinemachineVC.LookAt = playerTransform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}