using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserController : MonoBehaviour
{
    public PlayerController player;

    private Collider2D collider2D;
    private SpriteRenderer sprite;

    private bool isEnabled = true;

    private float time = 0f;

    public int interval = 10;

    void Start()
    {
        collider2D = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            player.transform.position = player.startPos;
            player.UI.deaths++;
            player.rigidBody.velocity = new Vector2(0, 0);
        }
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= interval)
        {
            collider2D.enabled = !isEnabled;
            sprite.enabled = !isEnabled;

            isEnabled = !isEnabled;
            time = 0;
        }
    }


}
