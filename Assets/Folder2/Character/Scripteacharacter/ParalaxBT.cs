﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBT : MonoBehaviour
{
    private Transform cameraTransform;
    private float textureunitsizeX;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureunitsizeX = texture.width / sprite.pixelsPerUnit;
    }

    void Update()
    {
        if ((cameraTransform.position.x - transform.position.x - 123.725f) >= textureunitsizeX)
        {
            float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureunitsizeX;
            transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y);
        }
    }
}
