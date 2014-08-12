using UnityEngine;
using System.Collections;

public class ColorTween : MonoBehaviour {

	// Use this for initialization

    Color from;
    Color to;

	void Start () {

        from = renderer.material.color;
        to = Color.white;
 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("Reveal");
        }
	}

    IEnumerator Reveal()
    {
        Go.to(transform, 3f, new GoTweenConfig()
            .materialColor(to)
            .setEaseType(GoEaseType.BounceOut)
            .setIterations(1));
        yield return new WaitForSeconds(5f);
        //StartCoroutine("Hide");
    }

    IEnumerator Hide()
    {
        Go.to(transform, 3f, new GoTweenConfig()
            .materialColor(from)
            .setEaseType(GoEaseType.BounceInOut)
            .setIterations(1));
        yield return new WaitForSeconds(0f);
    }


}
