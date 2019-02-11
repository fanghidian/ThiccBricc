using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpHUD : MonoBehaviour
{
    public Sprite[] hpSprites;
    public Image hpImage;
    private playerController health;

    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>();
    }

    void Update()
    {
        hpImage.sprite = hpSprites[health.curHealth];
    }
}