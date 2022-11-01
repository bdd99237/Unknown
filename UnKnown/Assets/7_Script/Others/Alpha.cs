using UnityEngine;
using System.Collections;

public class Alpha : MonoBehaviour {
    [SerializeField]
    GameObject Picture;
    SpriteRenderer renderer;

    public float alpha_a = 0.5f;
    bool check = false;

    void Start()
    {
        renderer = Picture.GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (check == true)
        {
            renderer.color -= new Color(0, 0, 0, alpha_a * Time.deltaTime);
        }

        if(renderer.color.a == 1.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            check = true;
        }
    }
}
