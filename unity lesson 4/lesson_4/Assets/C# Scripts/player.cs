using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 3f)
            {
                transform.position = transform.position + new Vector3(3f, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -3f)
            {
                transform.position = transform.position + new Vector3(-3f, 0, 0);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemies")
            SceneManager.LoadScene("SampleScene");
    }
}
