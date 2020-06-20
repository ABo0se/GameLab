using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax2 : MonoBehaviour
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
        if ((cameraTransform.position.x - transform.position.x - 138.8f) >= textureunitsizeX)
        {
            float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureunitsizeX;
            transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y);
        }
    }
}