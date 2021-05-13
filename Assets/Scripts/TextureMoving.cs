using UnityEngine;

public class TextureMoving : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.5f;
    private Renderer renderer;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = Time.time * moveSpeed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(-offset, 0));
    }
}
