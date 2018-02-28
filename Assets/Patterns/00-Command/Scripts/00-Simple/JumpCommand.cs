using UnityEngine;
using System.Collections;
namespace GamePatterns.Command.Simple {
    public class JumpCommand : Command {
        public override void Execute() {
            Debug.LogFormat("Execute - {0}", GetType());
            base.Execute();
        }

        void Jump() {
            Debug.LogFormat("Jump");
        }
    }
}