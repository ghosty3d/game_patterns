using UnityEngine;
using System.Collections;

namespace GamePatterns.Command.Actor {
    public class MoveForwardCommand : Command
    {
        public override void Execute(Transform actor) {
            Debug.LogFormat("Execute - {0}", GetType());
            float vertical = Input.GetAxis("Vertical");
            actor.GetComponent<Rigidbody>().velocity = new Vector3(actor.position.x, actor.position.y, vertical * 5f);
            base.Execute(actor);
        }
    }
}
