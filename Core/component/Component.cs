using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Component
{
    [System.Serializable]
   public class Component
    {
        [System.NonSerialized]
        public GameObject gameObject;
        // public Transform transform { get { return gameObject.transform; } }
        public bool enabled = true;
        /// <summary>
        /// The code that is run when Component is made or when the game starts
        /// </summary>
        /// <param name="gameObject">parent gameobject</param>
        public virtual void Start(GameObject gameObject) { this.gameObject = gameObject; }
        /// <summary>
        /// Runs every frame
        /// </summary>
        public virtual void Update() { }
    }
}
