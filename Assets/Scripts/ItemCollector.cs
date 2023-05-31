using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource PickupSoundEffect;
    [SerializeField] private Text BananaText;
    private int bananas = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
            PickupSoundEffect.Play();
            Destroy(collision.gameObject);
            bananas++;
            Debug.Log("banana:" + bananas);
            BananaText.text = "Banany: "+bananas;
        }
    }
}
