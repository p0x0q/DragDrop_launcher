using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop_launcher
{
    public partial class Form1 : Form
    {
        public static Hashtable config = new Hashtable();
        public Form1()
        {
            InitializeComponent();
            Form1.CheckForIllegalCrossThreadCalls = false;

            DLL.main.appcheck(DLL.main.myappname());
            DLL.main.FormStart("DragDrop_launcher", DLL.main.myappname());
            //DLL.form.Icon("chat", Properties.Resources.Icon, this);
            DLL.form.Form_Closing(this);
            var result = DLL.main.thisupdate(DLL.main.myappname(), "DragDrop_launcher", false);

            label1_drop.DragEnter += new DragEventHandler(label1_drop_DragEnter);
            //DragDropイベントハンドラを追加
            label1_drop.DragDrop += new DragEventHandler(label1_drop_DragDrop);

            string json = nao0x0.JSON.Load();
            if (json != string.Empty)
            {
                config = nao0x0.JSON.ToHashtable(json);

                if (config["folder_path"] != null)
                    textBox3_folderpath.Text = config["folder_path"].ToString();

                if (config["parameters"] != null)
                    textBox1_parameters.Text = config["parameters"].ToString();
            }

        }

        private void label1_drop_DragEnter(object sender, DragEventArgs e)
        {
            //URLのみ受け入れる
            if (e.Data.GetDataPresent("UniformResourceLocator"))
                e.Effect = DragDropEffects.Link;
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Link;//Copy
            else
                e.Effect = DragDropEffects.None;
        }

        public void drop_execute()
        {
            Hashtable setconfig = new Hashtable();

            string folder_path = textBox3_folderpath.Text;
            string parameters = textBox1_parameters.Text;

            setconfig["folder_path"] = folder_path;
            setconfig["parameters"] = parameters;

            nao0x0.JSON.Save(nao0x0.JSON.ToJSON(setconfig));
            try
            {
                if (parameters != string.Empty)
                {
                    DLL.main.ProcessStart(folder_path, parameters + " " + textBox1_drop.Text);
                }
                else
                {
                    DLL.main.ProcessStart(folder_path, textBox1_drop.Text);
                }

            }
            catch (Exception ee)
            {
                DLL.Message.AlertWindow(ee.Message, DLL.main.appid + " - 起動中にエラーが発生しました");
            }
        }

        private void label1_drop_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップされたリンクのURLを取得する
            string url = e.Data.GetData(DataFormats.Text).ToString();
            //結果を表示
            textBox1_drop.Text = url;

            drop_execute();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hashtable setconfig = new Hashtable();

            string folder_path = textBox3_folderpath.Text;
            string parameters = textBox1_parameters.Text;

            setconfig["folder_path"] = folder_path;
            setconfig["parameters"] = parameters;

            nao0x0.JSON.Save(nao0x0.JSON.ToJSON(setconfig));
        }

        private void button1_execute_Click(object sender, EventArgs e)
        {
            drop_execute();
        }
    }
}
