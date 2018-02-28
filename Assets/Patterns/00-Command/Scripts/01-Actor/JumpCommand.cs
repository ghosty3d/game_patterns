using UnityEngine;
using System.Collections;

namespace GamePatterns.Command.Actor {
    public class JumpCommand : Command {

        public override void Execute(Transform actor) {
            Debug.LogFormat("Execute - {0}", GetType());
            actor.GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
            base.Execute(actor);
        }
    }
}