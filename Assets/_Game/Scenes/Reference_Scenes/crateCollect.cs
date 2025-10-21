using NUnit.Framework;
using UnityEngine;

public class crateCollect : MonoBehaviour
{
    [SerializeField] private AudioClip collectionNoise;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.instance.PlayAudioClip(collectionNoise, transform, 1f);
            Destroy(gameObject);
        }
    }  
}
