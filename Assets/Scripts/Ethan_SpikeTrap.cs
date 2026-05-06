using UnityEngine;

public class Ethan_SpikeTrap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            print("Player hit!");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
