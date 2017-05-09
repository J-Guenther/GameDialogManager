using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogManager {
    class DialogId {
        private int chapter;
        private int scene;
        private int dlcNumber;

        public DialogId(int _chapter, int _scene, int _dlcNumber) {
            chapter = _chapter;
            scene = _scene;
            dlcNumber = _dlcNumber;
        }

        public static bool operator ==(DialogId id1, DialogId id2) {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(id1, id2))
                return true;
            // If one is null, but not both, return false.
            if (((object)id1 == null) || ((object)id2 == null))
                return false;
            // Return true if the fields match:
            return id1.chapter == id2.chapter && id1.scene == id2.scene && id1.dlcNumber == id2.dlcNumber;
        }

        public static bool operator !=(DialogId id1, DialogId id2) {
            return !(id1 == id2);
        }

        public override bool Equals(System.Object obj) {
            // If parameter is null return false.
            if (obj == null)
                return false;
            // If parameter cannot be cast to Point return false.
            DialogId p = obj as DialogId;
            if ((System.Object)p == null)
                return false;
            // Return true if the fields match:
            return (chapter == p.chapter) && (scene == p.scene) && (dlcNumber == p.dlcNumber);
        }

        public bool Equals(DialogId p) {
            // If parameter is null return false:
            if ((object)p == null)
                return false;
            // Return true if the fields match:
            return (chapter == p.chapter) && (scene == p.scene) && (dlcNumber == p.dlcNumber);
        }

        public override int GetHashCode() {
            string hashString = "" + chapter + scene + dlcNumber;
            return hashString.GetHashCode();
        }

        public override string ToString() {
            return "" + chapter + "_" + scene + "_" + dlcNumber;
        }

        // Getter and Setter
        public int Chapter { get { return chapter; } private set { } }
        public int Scene { get { return scene; } private set { } }
        public int DlcNumber { get { return dlcNumber; } private set { } }
    }
}
