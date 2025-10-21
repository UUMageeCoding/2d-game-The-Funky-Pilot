using Unity.Mathematics;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private AudioSource audioObject;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlayAudioClip(AudioClip audioClip, Transform AudioTransform, float volume)
    {
        //gameobject spawn
        AudioSource audioSource = Instantiate(audioObject, AudioTransform.position, quaternion.identity);

        //assign audio source
        audioSource.clip = audioClip;

        //assinging volume
        audioSource.volume = volume;

        //play sound
        audioSource.Play();

        //length of clip
        float clipLength = audioSource.clip.length;

        //destroy clip
        Destroy(audioSource.gameObject, clipLength);

    }

}
