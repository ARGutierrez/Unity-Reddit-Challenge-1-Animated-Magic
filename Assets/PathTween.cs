using UnityEngine;
using System.Collections;

public class PathTween : MonoBehaviour {

	// Use this for initialization
    Vector3 fromPos;
    Vector3 toPos;

    Vector3 fromRot;
    Vector3 toRot;

	void Start () {

        fromPos = transform.position;
        toPos = new Vector3(-4.370929f, 3f, -8.518437f);

        fromRot = transform.rotation.eulerAngles;
        toRot = new Vector3(-90, 90, 270);

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
            .position(toPos)
            .rotation(toRot)
            .setEaseType(GoEaseType.BounceOut)
            .setIterations(1));
        yield return new WaitForSeconds(5f);
        //StartCoroutine("Hide");
    }

    IEnumerator Hide()
    {
        Go.to(transform, 3f, new GoTweenConfig()
            .position(fromPos)
            .rotation(fromRot)
            .setEaseType(GoEaseType.BounceInOut)
            .setIterations(1));
        yield return new WaitForSeconds(0f);
    }
}
