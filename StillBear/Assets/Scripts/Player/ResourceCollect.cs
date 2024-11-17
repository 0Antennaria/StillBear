using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class ResourceCollect : MonoBehaviour
{
    public static float _honey = 0;
    [SerializeField] Text HoneyAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HoneyAmount.text = _honey.ToString();
    }
}
