using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogManager {
    class DialogLineContainer {
        public DialogId dialogId;

        public DialogLineContainer(int _chapter, int _scene, int _dlcNumber) {
            dialogId = new DialogId(_chapter, _scene, _dlcNumber);
        }

        public override string ToString() {
            return "" + dialogId.Chapter + "_" + dialogId.Scene + "_" + dialogId.DlcNumber;
        }
    }
}
