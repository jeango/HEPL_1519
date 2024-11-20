using UnityEngine;

public class TextureMover : MonoBehaviour
{
    public Renderer renderer;
    public Vector2 direction;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        renderer.material.mainTextureOffset += direction.normalized * speed * Time.deltaTime;
    }
}
