using UnityEngine;

public class SlimeController : MonoBehaviour
{
    public Rigidbody2D[] nodes;
    public float forceAmount = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            foreach (var node in nodes)
            {
                Vector2 direction = (node.position - mousePos).normalized;
                node.AddForce(direction * forceAmount, ForceMode2D.Impulse);
            }
        }
    }
}
