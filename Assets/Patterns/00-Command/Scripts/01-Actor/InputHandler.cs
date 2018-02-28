using UnityEngine;
using System.Collections;

namespace GamePatterns.Command.Actor {
    public class InputHandler : MonoBehaviour {

        Command _buttonW;
        Command _buttonSpace;

        void Start() {
            _buttonW = new MoveForwardCommand();
            _buttonSpace = new JumpCommand();
        }

        void Update() {
            Command command = HandleInput();
            if(command != null) {
                command.Execute(GameObject.FindGameObjectWithTag("Player").transform);
            }
        }

        Command HandleInput() {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) return _buttonW;
            if (Input.GetKeyDown(KeyCode.Space)) return _buttonSpace;

            return null;
        }
    }
}