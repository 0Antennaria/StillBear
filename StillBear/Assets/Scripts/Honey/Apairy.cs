using System.Collections;
using UnityEngine;

public class Apairy : MonoBehaviour
{
    private Honey _honey;

    private void OnEnable()
    {
        _honey = FindAnyObjectByType<Honey>();
    }

    private IEnumerator AddHoney()
    {
        _honey.ChangeHoney(2);
        yield return new WaitForSeconds(3);
    }
}
