using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("erste Tests mit Operatoren");

        Debug.Log("Addition " + (5+2));
        Debug.Log("Multiplikation " + (6*12));
        Debug.Log("Subtraktion " + (124050-10250));

        Operators();
        XY();
        Nose();
        Count();
    }

    public void Operators()
    {
        Debug.Log("Test");
    }

    public void XY()
    {
        Debug.Log("something");
    }

    void Nose()
    {
        Debug.Log("Leg");
    }
    private void Count()
    {
        Debug.Log((8+6-4+26-12));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
