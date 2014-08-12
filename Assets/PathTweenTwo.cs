using UnityEngine;
using System.Collections;

public class PathTweenTwo : MonoBehaviour {

    Vector3 fromPos;
    Vector3 toPos;

    // Use this for initialization
	void Start () 
    {
        fromPos = transform.position;
        toPos = new Vector3(10.81509f, -7.891701f, 7.15f);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("Reveal");
        }
	}

    IEnumerator Reveal()
    {
        Go.to(transform, 3f, new GoTweenConfig()
            .position(toPos)
            .setEaseType(GoEaseType.BounceOut)
            .setIterations(1));
        yield return new WaitForSeconds(5f);
        //StartCoroutine("Hide");
    }

    IEnumerator Hide()
    {
        Go.to(transform, 3f, new GoTweenConfig()
            .position(fromPos)
            .setEaseType(GoEaseType.BounceInOut)
            .setIterations(1));
        yield return new WaitForSeconds(0f);
    }
}
