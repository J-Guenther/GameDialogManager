using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogManager {
    class DialogLine {
        private int id;
        private DialogId dlcId;
        private string character;
        private string contentGer;
        private string contentEng;
        private bool isEntry;
        private bool isJump;
        private string requirements;
        private int eventTrigger; // Quest or Event ID
        private string audioFileGer; // Path or ID
        private string audioFileEng; // Path or ID
        private float pause;

        public int previous;
        public List<int> next; // fixed list
        public int activeNexts;

        public DialogLine(DialogId _dlcId) {
            id = -1;
            dlcId = _dlcId;
            character = "Nobody";
            contentGer = "Nix";
            contentEng = "Nothing";
            isEntry = false;
            isJump = false;
            previous = -1;
            next = new List<int>(new int[] { 0, 0, 0, 0 });
            activeNexts = 0;
            requirements = "None";
            eventTrigger = 0;
            audioFileGer = "Nix";
            audioFileEng = "None";
            pause = 0.0f;
        }

        public DialogLine(DialogLineContainer _dlcId) {
            id = -1;
            dlcId = _dlcId.dialogId;
            character = "Nobody";
            contentGer = "Nix";
            contentEng = "Nothing";
            isEntry = false;
            isJump = false;
            previous = -1;
            next = new List<int>(new int[] { 0, 0, 0, 0 });
            activeNexts = 0;
            requirements = "None";
            eventTrigger = 0;
            audioFileGer = "Nix";
            audioFileEng = "None";
            pause = 0.0f;
        }

        public override string ToString() {
            return "" + dlcId + "-" + id;
        }

        public void UpdateActiveNexts() {
            activeNexts = 0;
            foreach (int i in next) {
                if (i > 0)
                    activeNexts++;
            }
        }

        // Getter and Setter
        public int Id { get { return id; } set { id = value; } }
        public DialogId DlcId { get { return dlcId; } private set { } }
        public string Character { get { return character; } set { character = value; } }
        public string ContentGer { get { return contentGer; } set { contentGer = value; } }
        public string ContentEng { get { return contentEng; } set { contentEng = value; } }
        public bool IsEntry { get { return isEntry; } set { isEntry = value; } }
        public bool IsJump { get { return isJump; } set { isJump = value; } }
        public string Requirements { get { return requirements; } set { requirements = value; } }
        public int EventTrigger { get { return eventTrigger; } set { eventTrigger = value; } }
        public string AudioFileGer { get { return audioFileGer; } set { audioFileGer = value; } }
        public string AudioFileEng { get { return audioFileEng; } set { audioFileEng = value; } }
        public float Pause { get { return pause; } set { pause = value; } }
    }
}
