using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{
    public int test1;
    public float test2;
    public string test3;

	// Use this for initialization
	void Start () 
    {
        test1 = 1;
        Debug.Log("test1 in Start " + test1);

        Debug.Log("erste Tests mit Operatoren");

        Debug.Log("Addition " + (5+2));
        Debug.Log("Multiplikation " + (6*12));
        Debug.Log("Subtraktion " + (124050-10250));

        //calling methods
        Nose();
        Count();
        AddNumbers(245,3);
        MultiNumbers(3,9,3);
        Combine();
        Debug.Log(MyText("EStr"));
        string drama = MyText("Stranze");
        Debug.Log("neu " + drama);
        Laugh();
    }
    //console giving word in brackets
    void Nose()
    {
        Debug.Log("Leg");
    }

    //text and space with an math
    private void Count()
    {
        Debug.Log("adding to " + (8+6-4+26-12));
    }

    //variables that are giving values
    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("add numbers " + (c));
        test1 = 3;
        Debug.Log("test1 in addNumbers " + test1);
    }

    //string (text) for my name
    public string MyText(string myName)
    { 
        return "Drama " + " " + myName;
    }

    public void MultiNumbers(float y,float x, int b)
    {
        float z = y * x - b;
        Debug.Log("your answer is " + (z));
    }

    //operator activating other methods with different values
    void Combine()
    {
        MultiNumbers(3, 9, 3);
        AddNumbers(245, 3);
    }

    //experiment
    void Laugh()
    {
        float points = 8;
        int level = 12;
        int enemy = 350;
        float multiplier = enemy / level;
        float exp = points * multiplier;
        Debug.Log("you got " + (exp) + " experience points");
    }
}
