using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FluteHole : MonoBehaviour
{
    public int number;
    public GameObject signal;
    //private Collider holeCollider;

    // Start is called before the first frame update
    void Start()
    {
        signal.SetActive(false);
        //holeCollider = this.GetComponent<Collider>();
    }

    void OnCollisionEnter(Collision target)
    {
        Debug.Log("Collider Enter");
        NoteManager.instance.AddHole(number);
    }

    void OnCollisionExit(Collision target)
    {
        Debug.Log("Collider Exit");
        NoteManager.instance.RemoveHole(number);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
