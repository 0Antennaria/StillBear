using UnityEngine;
using UnityEngine.UI;

public class BeeQueen : MonoBehaviour
{
    //[SerializeField] public float HarvesingSpeed { get; private set; }
    //[SerializeField] public float ProcessingSpeed { get; private set; }
    //[SerializeField] public Image _avatar { get; private set; }
    //[SerializeField] public string _name { get; private set; }
    //[SerializeField] public string _rarity { get; private set; }
    //public int index;
    [SerializeField] private float HarvesingSpeed;
    [SerializeField] private float ProcessingSpeed;
    [SerializeField] private Image _avatar;
    [SerializeField] private string _name;
    [SerializeField] private string _rarity;

    public float ChangeSpeed()
    {
        return HarvesingSpeed + ProcessingSpeed;
    }
    public Image GetAvatar()
    {
        return _avatar;
    }
}
