using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class QueensVault : BeeQueen //это тестовый класс, хранение всех маток должнор быть в облаке
{
    List<BeeQueen> Queens = new List<BeeQueen>();
    [SerializeField] Image TestAvatar;
    [SerializeField] private RectTransform content;

    public List<BeeQueen> PlayersQueens { get; private set; }

    //public void CreateNewQueen()
    //{
    //    var newQueen = new QueensVault();
    //    newQueen._name = "TestQueen";
    //    newQueen._avatar = TestAvatar;
    //    newQueen.ChangeSpeed(1f, 1f);
    //    newQueen._rarity = "default";
    //    Queens.Add(newQueen);
    //    GameObject instance = Instantiate(TestAvatar.gameObject, content);
    //}
}
