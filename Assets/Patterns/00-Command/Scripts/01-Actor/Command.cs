using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePatterns.Command.Actor {

    public class Command {
        public virtual void Execute(Transform actor) { }
    }
}