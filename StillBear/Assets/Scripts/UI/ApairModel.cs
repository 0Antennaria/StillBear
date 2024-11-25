using UnityEngine;

public class ApairModel : Model
{
    [SerializeField] private BeeHouse _house;
    public ApairModel(View view) : base(view)
    {
    }
    
    public void ChangeBeeQueen(BeeQueen newQueen, BeeHouse house)
    {
        _house = house;
        _house.OnQueenChange(newQueen);
    }
}
