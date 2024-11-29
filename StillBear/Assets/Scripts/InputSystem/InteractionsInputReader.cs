using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.InputSystem;

namespace Assets.Scripts.InputSystem
{
    internal class InteractionsInputReader
    {
        private InputSystemController _inputSystem;
        private bool _interactionsPressed;

        public bool InteractionsPressed => _interactionsPressed;

        public InteractionsInputReader()
        {
            _inputSystem = new InputSystemController();

            _inputSystem.Enable();

            _inputSystem.Player.Interactions.performed += OnInteractionsPressed;
            _inputSystem.Player.Interactions.canceled += OnInteractionsCanceled;
        }

        ~InteractionsInputReader()
        {
            _inputSystem.Player.Interactions.performed -= OnInteractionsPressed;
            _inputSystem.Player.Interactions.canceled -= OnInteractionsCanceled;

            _inputSystem.Disable();
        }

        private void OnInteractionsPressed(InputAction.CallbackContext ctx) => _interactionsPressed = true;

        private void OnInteractionsCanceled(InputAction.CallbackContext ctx) => _interactionsPressed = false;
    }
}
