using UnityEngine;
using System.Collections;

public class DestroyerPolled : MonoBehaviour {

    float halfWidth;
    float halfHeight;

    // Use this for initialization
    void Start () {

        Sprite sprite = GetComponent<SpriteRenderer>().sprite;

        halfWidth = sprite.bounds.size.x / 2;
        halfHeight = sprite.bounds.size.y / 2;

    }
	
	// Update is called once per frame
	void Update () {

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        max.x = max.x - halfWidth;
        min.x = min.x + halfWidth;
        max.y = max.y - halfHeight;
        min.y = min.y + halfHeight;

        if ((transform.position.x < min.x) || (transform.position.x > max.x) ||
            (transform.position.y < min.y) || (transform.position.y > max.y))
        {
            gameObject.SetActive(false);
        }

    }



}
