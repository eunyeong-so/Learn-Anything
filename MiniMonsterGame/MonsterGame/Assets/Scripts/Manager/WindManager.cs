using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    private const float MaxTime = 5;
    private float mWindTime = 0;
    private float mWindTerm = 3;

    public static float WindPower = 0;
    public static Vector3 WindDir => new Vector3(WindPower * Time.deltaTime, 0, 0);
    IEnumerator Start()
    {
        yield return null;
        while (true)
        {
            yield return new WaitForSeconds(mWindTerm);
            mWindTerm = Random.Range(0, MaxTime);
            mWindTime = Random.Range(0, MaxTime);
            WindPower = Random.Range(-1f, 1f);
            yield return new WaitForSeconds(mWindTime);
            WindPower = 0;
        }
    }
}
