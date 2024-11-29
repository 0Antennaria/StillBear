using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI.ShipMenu
{
    internal class ShipMenu : MonoBehaviour
    {
        [SerializeField] private Ship _ship;

        private void OnEnable()
        {
            _ship.OnPlayerEnteredToShip += Enable;
            _ship.OnPlayerExitedFromShip += Disable;
        }

        private void OnDisable()
        {
            _ship.OnPlayerEnteredToShip -= Enable;
            _ship.OnPlayerExitedFromShip -= Disable;
        }

        private void Enable() 
        {
            Time.timeScale = 0;
            gameObject.SetActive(true);

            print(Time.timeScale);
        }

        private void Disable()
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }
}
