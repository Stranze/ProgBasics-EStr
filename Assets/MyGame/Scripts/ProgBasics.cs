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
        AddNumbers(245,3);
        MultiNumbers(3,9,3);
        MultiNumbers(7, 14, 34);
        Combine();
        Debug.Log(MyText("EStr"));
        string drama = MyText("Stranze");
        Debug.Log("neu " + drama);
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
        Debug.Log("adding to " + (8+6-4+26-12));
    }

    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("add numbers " + (c));
    }

    public string MyText(string myName)
    {
        Debug.Log("Drama ");
        return "Drama " + " " + myName;
    }

    public void MultiNumbers(float y,float x, int b)
    {
        float z = y * x - b;
        Debug.Log("your answer is " + (z));
    }

    void Combine()
    {
        MultiNumbers(3, 9, 3);
        AddNumbers(245, 3);
    }




    // Update is called once per frame
    void Update () {
		
	}
}
