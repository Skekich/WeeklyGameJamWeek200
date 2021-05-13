using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeCollider : MonoBehaviour
{
    private BoxCollider2D collider;
    private Vector2 bounds;

    private void Start() {
        collider = gameObject.GetComponent<BoxCollider2D>();
        bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        collider.size = new Vector2(collider.size.x/2, bounds.y*2);
    }
}
