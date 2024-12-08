using System.Collections;
using UnityEngine;

public class Apairy : MonoBehaviour
{
    private Honey _honey;

    private void Start()
    {
        _honey = FindAnyObjectByType<Honey>();
        StartCoroutine(AddHoney());
    }

    private IEnumerator AddHoney()
    {
        while (true)
        {
            _honey.ChangeHoney(2);
            yield return new WaitForSeconds(3);
        }
    }
}
