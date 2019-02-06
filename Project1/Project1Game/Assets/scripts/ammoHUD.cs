using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoHUD : MonoBehaviour
{
    public Sprite[] ammoSprites;
    public Image ammoImage;
    private weapon ammo;

    void Start()
    {
        ammo = GameObject.FindGameObjectWithTag("Player").GetComponent<weapon>();
    }


    void Update()
    {
        ammoImage.sprite = ammoSprites[ammo.currAmmo];
    }
}
