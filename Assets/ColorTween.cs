using UnityEngine;
using System.Collections;

public class ColorTween : MonoBehaviour {


    Color fromColor;
    Color toColor;

    // Use this for initialization
	void Start () 
    {
        fromColor = renderer.material.color;
        toColor = Color.white;
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
            .materialColor(toColor)
            .setEaseType(GoEaseType.BounceOut)
            .setIterations(1));
        yield return new WaitForSeconds(5f);
        //StartCoroutine("Hide");
    }

    IEnumerator Hide()
    {
        Go.to(transform, 3f, new GoTweenConfig()
            .materialColor(fromColor)
            .setEaseType(GoEaseType.BounceInOut)
            .setIterations(1));
        yield return new WaitForSeconds(0f);
    }


}
