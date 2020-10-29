using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    private SpriteRenderer quadRenderer;

    public float scrollSpeed = 0.01f;

    void Start()
    {
        quadRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 textureOffset = new Vector2(Time.time * scrollSpeed, 0);
        quadRenderer.material.SetTextureOffset("_MainTex", textureOffset);
    }
}
