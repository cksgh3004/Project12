using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Sensor : MonoBehaviour
{
    private VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        video.Play();
    }

    private void OnTriggerStay(Collider other)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void OnTriggerExit(Collider other)
    {
        video.Stop();
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

}
