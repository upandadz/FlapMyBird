using UnityEngine;

public class SFXManager : MonoBehaviour
{
    
    public static SFXManager instance;
    public AudioClip[] audioClips;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
