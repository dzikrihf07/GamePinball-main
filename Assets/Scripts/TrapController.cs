using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrapController : MonoBehaviour
{
    public Collider bola;
    public GameObject trap, ObjBola;
    //private Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        //originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider == bola)
        {
            //Debug.Log("Kena Coin");
            trap.SetActive(false);
            //ObjBola.transform.position = originalPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
