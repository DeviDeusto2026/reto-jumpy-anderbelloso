using UnityEngine;

public class PlatformCollider : MonoBehaviour
{
    private Collider platformCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platformCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject fox = GameObject.FindWithTag("Fox");

        if (fox != null)
        {
            if (fox.transform.position.y > transform.position.y)
            {
                platformCollider.isTrigger = false;
            }
            else
            {
                platformCollider.isTrigger = true;
            }
        }
    }
}
