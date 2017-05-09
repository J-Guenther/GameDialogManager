using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DialogManager {
    class DataBase {
        private string dataSource;
        private SQLiteConnection connection;

        public DataBase(string _dataSource) {
            dataSource = _dataSource;
            connection = null;
        }

        public void OpenConnection() {
            if (connection == null) { // && connection.State  != System.Data.ConnectionState.Open
                connection = new SQLiteConnection();
                connection.ConnectionString = "Data Source=" + dataSource;
                connection.Open();
            }
            else { throw new Exception("Unable to open Connection"); }
        }

        public void CloseConnection() {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                connection.Close();
                connection.Dispose();
            }
            else { throw new Exception("Unable to close Connection"); }
        }

        public void Create() {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "CREATE TABLE IF NOT EXISTS dialogDb( " +
                    "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                    "character VARCHAR(30) NOT NULL," +
                    "contentGer VARCHAR(500) NOT NULL," +
                    "contentEng VARCHAR(500) NOT NULL," +
                    "previous VARCHAR(15) NOT NULL," +
                    "next0 VARCHAR(15) NOT NULL," +
                    "next1 VARCHAR(15) NOT NULL," +
                    "next2 VARCHAR(15) NOT NULL," +
                    "next3 VARCHAR(15) NOT NULL," +
                    "activeNexts INTEGER NOT NULL," +
                    "isEntry VARCHAR(5) NOT NULL," +
                    "isJump VARCHAR(5) NOT NULL," +
                    "requirements VARCHAR(50) NOT NULL," +
                    "chapter INTEGER NOT NULL," +
                    "scene INTEGER NOT NULL," +
                    "dlcNumber INTEGER NOT NULL," +
                    "eventTrigger INTEGER NOT NULL," +
                    "audioFileGer VARCHAR(100) NOT NULL," +
                    "audioFileEng VARCHAR(100) NOT NULL," +
                    "pause REAL NOT NULL" +
                    ");";
                command.ExecuteNonQuery();
                command.Dispose();
            }
            else { throw new Exception("Invalid data base connection."); }

        }

        public void Insert(DialogLine line) {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO dialogDb (id, character, contentGer, contentEng, previous, next0, next1, next2, next3, activeNexts, isEntry, isJump, requirements, chapter, scene, dlcNumber, eventTrigger, audioFileGer, audioFileEng, pause) VALUES(" +
                    "NULL, '" +
                    line.Character + "','" +
                    line.ContentGer + "','" +
                    line.ContentEng + "','" +
                    line.previous + "','" +
                    line.next[0] + "','" +
                    line.next[1] + "','" +
                    line.next[2] + "','" +
                    line.next[3] + "','" +
                    line.activeNexts + "','" +
                    Convert.ToString(line.IsEntry) + "','" +
                    Convert.ToString(line.IsJump) + "','" +
                    line.Requirements + "','" +
                    line.DlcId.Chapter + "','" +
                    line.DlcId.Scene + "','" +
                    line.DlcId.DlcNumber + "','" +
                    line.EventTrigger + "','" +
                    line.AudioFileGer + "','" +
                    line.AudioFileEng + "','" +
                    line.Pause + "'" +
                    ")";
                command.ExecuteNonQuery();
                command.Dispose();
            }
            else { throw new Exception("Invalid data base connection."); }

        }

        public void ReadAll() {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * " +
                    "FROM dialogDb ORDER BY id ASC";
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    Console.WriteLine("DB-ID: {0}\n" +
                        "Character: \"{1}\"\n" +
                        "ContentGer: \"{2}\"\n" +
                        "ContentEng: \"{3}\"\n" +
                        "Previous: \"{4}\"\n" +
                        "Next0: \"{5}\"\n" +
                        "Next1: \"{6}\"\n" +
                        "Next2: \"{7}\"\n" +
                        "Next3: \"{8}\"\n" +
                        "activeNexts: \"{9}\"\n" +
                        "isEntry: \"{10}\"\n" +
                        "isJump: \"{11}\"\n" +
                        "Requirements: \"{12}\"\n" +
                        "Chapter: \"{13}\"\n" +
                        "Scene: \"{14}\"\n" +
                        "dlcNumber: \"{15}\"\n" +
                        "EventTrigger: \"{16}\"\n" +
                        "AudioFileGer: \"{17}\"\n" +
                        "AudioFileEng: \"{18}\"\n" +
                        "Pause: \"{19}\"\n", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString());
                }
                reader.Close();
                reader.Dispose();
                command.Dispose();
            }
            else { throw new Exception("Invalid data base connection."); }

        }

        public List<DialogLine> GetLinesByDialogId(DialogLineContainer dlc) {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * " +
                    "FROM dialogDb WHERE chapter = " + dlc.dialogId.Chapter + " AND scene = " + dlc.dialogId.Scene + " AND dlcNumber = " + dlc.dialogId.DlcNumber + " ORDER BY id ASC";
                SQLiteDataReader reader = command.ExecuteReader();

                List<DialogLine> dialogLinesList = new List<DialogLine>();

                while (reader.Read()) {
                    DialogLine dl = new DialogLine(dlc);
                    dl.Id = Convert.ToInt32(reader[0].ToString());
                    dl.Character = reader[1].ToString();
                    dl.ContentGer = reader[2].ToString();
                    dl.ContentEng = reader[3].ToString();
                    dl.previous = Convert.ToInt32(reader[4].ToString());
                    dl.next[0] = Convert.ToInt32(reader[5].ToString());
                    dl.next[1] = Convert.ToInt32(reader[6].ToString());
                    dl.next[2] = Convert.ToInt32(reader[7].ToString());
                    dl.next[3] = Convert.ToInt32(reader[8].ToString());
                    dl.activeNexts = Convert.ToInt32(reader[9].ToString());
                    dl.IsEntry = Convert.ToBoolean(reader[10]);
                    dl.IsJump = Convert.ToBoolean(reader[11]);
                    dl.Requirements = reader[12].ToString();
                    dl.EventTrigger = Convert.ToInt32(reader[16].ToString());
                    dl.AudioFileGer = reader[17].ToString();
                    dl.AudioFileEng = reader[18].ToString();
                    dl.Pause = (float)Convert.ToDouble(reader[19].ToString());
                    Console.WriteLine(dl);
                    dialogLinesList.Add(dl);
                }
                reader.Close();
                reader.Dispose();
                command.Dispose();
                return dialogLinesList;
            }
            else { throw new Exception("Invalid data base connection."); }
        }

        public DialogLine GetLineById(int id) {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM dialogDb WHERE id = " + id;
                SQLiteDataReader reader = command.ExecuteReader();

                DialogLine dl = null;

                while (reader.Read()) {
                    DialogId dId = new DialogId(Convert.ToInt32(reader[13].ToString()), Convert.ToInt32(reader[14].ToString()), Convert.ToInt32(reader[15].ToString()));
                    dl = new DialogLine(dId);
                    dl.Id = Convert.ToInt32(reader[0].ToString());
                    dl.Character = reader[1].ToString();
                    dl.ContentGer = reader[2].ToString();
                    dl.ContentEng = reader[3].ToString();
                    dl.previous = Convert.ToInt32(reader[4].ToString());
                    dl.next[0] = Convert.ToInt32(reader[5].ToString());
                    dl.next[1] = Convert.ToInt32(reader[6].ToString());
                    dl.next[2] = Convert.ToInt32(reader[7].ToString());
                    dl.next[3] = Convert.ToInt32(reader[8].ToString());
                    dl.activeNexts = Convert.ToInt32(reader[9].ToString());
                    dl.IsEntry = Convert.ToBoolean(reader[10]);
                    dl.IsJump = Convert.ToBoolean(reader[11]);
                    dl.Requirements = reader[12].ToString();
                    dl.EventTrigger = Convert.ToInt32(reader[16].ToString());
                    dl.AudioFileGer = reader[17].ToString();
                    dl.AudioFileEng = reader[18].ToString();
                    dl.Pause = (float)Convert.ToDouble(reader[19].ToString());
                    Console.WriteLine(dl);
                }
                reader.Close();
                reader.Dispose();
                command.Dispose();
                return dl;
            }
            else { throw new Exception("Invalid data base connection."); }
        }

        public void UpdateLineByID(DialogLine dl) {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "UPDATE dialogDb SET " +
                    "character = '" + dl.Character + "'," +
                    "contentGer = '" + dl.ContentGer + "'," +
                    "contentEng = '" + dl.ContentEng + "'," +
                    "previous = '" + dl.previous + "'," +
                    "next0 = '" + dl.next[0] + "'," +
                    "next1 = '" + dl.next[1] + "'," +
                    "next2 = '" + dl.next[2] + "'," +
                    "next3 = '" + dl.next[3] + "'," +
                    "activeNexts = '" + dl.activeNexts + "'," +
                    "isEntry = '" + Convert.ToString(dl.IsEntry) + "'," +
                    "isJump = '" + Convert.ToString(dl.IsJump) + "'," +
                    "requirements = '" + dl.Requirements + "'," +
                    "eventTrigger = '" + dl.EventTrigger + "'," +
                    "audioFileGer = '" + dl.AudioFileGer + "'," +
                    "audioFileEng = '" + dl.AudioFileEng + "'," +
                    "pause = '" + dl.Pause + "' " +
                    "WHERE id = " + dl.Id;
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Close();
                reader.Dispose();
                command.Dispose();
            }
            else { throw new Exception("Invalid data base connection."); }
        }

        public List<DialogLineContainer> GetUniqueDlcIds() {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT DISTINCT chapter, scene, dlcNumber FROM dialogDb";
                SQLiteDataReader reader = command.ExecuteReader();

                List<DialogLineContainer> dlcList = new List<DialogLineContainer>();

                while (reader.Read()) {
                    DialogLineContainer dlc = new DialogLineContainer(Convert.ToInt32(reader[0].ToString()), Convert.ToInt32(reader[1].ToString()), Convert.ToInt32(reader[2].ToString()));
                    dlcList.Add(dlc);
                }
                reader.Close();
                reader.Dispose();
                command.Dispose();
                return dlcList;
            }
            else { throw new Exception("Invalid data base connection."); }
        }

        public int GetLatestId() {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT MAX(id) FROM dialogDb";
                SQLiteDataReader reader = command.ExecuteReader();

                int id = 0;
                string idString = "";
                while (reader.Read()) {
                    idString = reader[0].ToString();
                    if (idString.Length > 0)
                        id = Convert.ToInt32(idString);
                    else
                        id = 0;
                }
                reader.Close();
                reader.Dispose();
                command.Dispose();
                return id;
            }
            else { throw new Exception("Invalid data base connection."); }
        }

        public void DeleteLineById(int id) {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM dialogDb WHERE id = " + id;
                SQLiteDataReader reader = command.ExecuteReader();

                reader.Close();
                reader.Dispose();
                command.Dispose();
            }
            else { throw new Exception("Invalid data base connection."); }
        }

        public void DeleteLineByDlc(DialogId dId) {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM dialogDb WHERE chapter = " + dId.Chapter + " AND scene = " + dId.Scene + " AND dlcNumber = " + dId.DlcNumber;
                SQLiteDataReader reader = command.ExecuteReader();

                reader.Close();
                reader.Dispose();
                command.Dispose();
            }
            else { throw new Exception("Invalid data base connection."); }
        }

        public SQLiteConnection GetConnection() {
            return connection;
        }
    }
}
