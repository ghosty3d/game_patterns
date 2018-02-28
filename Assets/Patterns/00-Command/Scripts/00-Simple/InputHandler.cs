using UnityEngine;
using System.Collections;
namespace GamePatterns.Command.Simple {
    public class InputHandler : MonoBehaviour {
        Command spaceButton;

        void Start() {
            spaceButton = new JumpCommand();
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.Space)) {
                spaceButton.Execute();
            }
        }
    }
}