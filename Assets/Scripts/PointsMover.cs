using UnityEngine;

public class PointsMover : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
