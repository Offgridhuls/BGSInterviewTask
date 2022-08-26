using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private PlayerBehaviour player;

    public SpriteRenderer torso,
      hood,
      pelvis;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        player = FindObjectOfType<PlayerBehaviour>();
    }


    public Sprite[] hoodSprites;

    public Sprite[] torsoSprites;

    public Sprite[] pelvisSprites;
    // Start is called before the first frame update
}
