using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ffxiv_data_eng2kor
{
    public partial class MainForm : Form
    {
        OpenFileDialog file_Open = new OpenFileDialog();
        SaveFileDialog file_Save = new SaveFileDialog();

        string openFile1 = "";
        string openFile2 = "";
        string saveFile = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_OpenFile1_Click(object sender, EventArgs e)
        {
            file_Open.Filter = "csv 파일|*.csv|모든 파일|*.*";
            if (file_Open.ShowDialog() == DialogResult.OK)
            {
                openFile1 = file_Open.FileName;
                label_OpenFile1.Text = file_Open.SafeFileName;
            }
        }

        private void button_OpenFile2_Click(object sender, EventArgs e)
        {
            file_Open.Filter = "csv 파일|*.csv|모든 파일|*.*";
            if (file_Open.ShowDialog() == DialogResult.OK)
            {
                openFile2 = file_Open.FileName;
                label_OpenFile2.Text = file_Open.SafeFileName;
            }
        }

        private void button_saveFile_Click(object sender, EventArgs e)
        {
            file_Save.Filter = "csv 파일|*.csv|모든 파일|*.*";
            if (file_Save.ShowDialog() == DialogResult.OK)
            {
                saveFile = file_Save.FileName;
                label_SaveFile.Text = Path.GetFileName(saveFile);
            }
        }

        private void button_StartConversion_Click(object sender, EventArgs e)
        {
            converse();
        }

        private void converse()
        {
            if (openFile1 == "" ||
                openFile2 == "" ||
                saveFile == "")
            {
                label_Status.Text = "경로 지정 필요";
                return;
            }
            else if (textBox_DataLocation.Text == "")
            {
                label_Status.Text = "번호 지정 필요";
            }
            else
            {
                label_Status.Text = "변환 중";

                //읽기
                StreamReader reader1 = new StreamReader(openFile1);
                StreamReader reader2 = new StreamReader(openFile2);
                List<string> listId = new List<string>();
                List<string> listIdHex = new List<string>();
                List<string> listLang1 = new List<string>();
                List<string> listLang2 = new List<string>();

                int dataLocation = Int32.Parse(textBox_DataLocation.Text)-1;
                // Lang1
                while (!reader1.EndOfStream)
                {
                    var line = reader1.ReadLine();
                    var values = line.Split(',');

                    // 맨 위에 필요 없는 줄 한 줄 있으면 건너뜀
                    if (values[0] == "Index") continue;

                    int i = Int32.Parse(values[0]) + 1;
                    string id = i.ToString();
                    listId.Add(id);
                    string hexValue = i.ToString("X");
                    listIdHex.Add(hexValue);
                    string lang1 = values[dataLocation];
                    listLang1.Add(lang1);
                }
                reader1.Close();
                // Lang2
                while (!reader2.EndOfStream)
                {
                    var line = reader2.ReadLine();
                    var values = line.Split(',');

                    // 맨 위에 필요 없는 줄 한 줄 있으면 건너뜀
                    if (values[0] == "Index") continue;

                    string lang2 = values[dataLocation];
                    listLang2.Add(lang2);
                }
                reader2.Close();

                //쓰기
                StreamWriter writer = new StreamWriter(saveFile);
                // for문 인덱스 배열 넘어가지 않도록, 최소 인덱스 값을 대입.
                int minLength = listIdHex.Count > listLang2.Count ? listLang2.Count : listIdHex.Count;
                for(int i = 0; i < minLength; i++)
                {
                    writer.WriteLine(listId[i] + "," + listIdHex[i] + "," + listLang1[i] + "," + listLang2[i]);
                }
                writer.Close();
                label_Status.Text = "변환 완료";
                label_SaveFile.Text = "저장할 파일 이름";
                saveFile = "";
            }
        }
    }
}
