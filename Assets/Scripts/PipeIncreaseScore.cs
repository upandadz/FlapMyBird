using System;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
            SFXManager.instance.PlaySFX(SFXManager.instance.audioClips[3]);
        }
    }
}
