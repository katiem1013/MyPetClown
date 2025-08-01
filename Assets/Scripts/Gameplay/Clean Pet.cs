using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanPet : MonoBehaviour
{
    [Header("References")]
    public GameObject wipePrefab;
    private Vector3 mousePosition;

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition = new Vector3(mousePosition.x, mousePosition.y, 0);
        wipePrefab.transform.position = mousePosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("cleaning");
            StartCoroutine("CleaningPet");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("not cleaning");
            StopCoroutine("CleaningPet");
        }
    }


    IEnumerator CleaningPet()
    {
        while (GameManager.instance.happiness > 0)
        {
            GameManager.instance.hygiene += 10;
            GameManager.instance.HeartClown();
            yield return new WaitForSeconds(1);
        }
    }
}
