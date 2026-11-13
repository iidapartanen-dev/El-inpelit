using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Asetetaan rajat milloin eläimet ja keksi deletoidaan ruudulta
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //Jos eläin pääsee pelaajan ohi
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
