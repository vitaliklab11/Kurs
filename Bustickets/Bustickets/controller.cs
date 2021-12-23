using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.OleDb;

namespace Bustickets
{

    class controller
    {
        public int switcher = 0;
        model model = new model();
        int count = 0;

        public void podckl(TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4)
        {
            model.con.Open();
            OleDbCommand cmd = model.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Таблица1 values('" + tx1.Text + "','" + tx2.Text + "','" + tx3.Text + "','" + tx4.Text + "')";
            cmd.ExecuteNonQuery();
            model.con.Close();
        }
        public void search(TextBox txs1, TextBox txs2, DataGridView dw)
        {
            model.cont.Open();
            OleDbCommand cmd = model.cont.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Таблица2 where fromC ='" + txs1.Text + "' and ToC = '" + txs2.Text + "'  ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dw.DataSource = dt;
            model.cont.Close();
        }
        public void vhod(TextBox txtuser, TextBox txtpass)
        {
            model.con.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter("Select * From Таблица1 where eml = '" + txtuser.Text + "'and pass = '" + txtpass.Text + "'", model.con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                switcher = 1;
            }
            else
            {
                switcher = 0;
            }
            model.con.Close();
        }
        public void rozklad(DataGridView dw)
        {
            model.cont.Open();
            OleDbCommand cmd = model.cont.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Таблица2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dw.DataSource = dt;
            model.cont.Close();
        }
        public void SaveText(TextBox textBox3, TextBox textBox4, TextBox textBox5, TextBox textBox6, TextBox textBox7)
        {
            string lines = " | " + textBox3.Text + " | " + textBox4.Text + " | " + textBox5.Text + " | " + textBox6.Text + " | " + textBox7.Text;
            System.IO.File.WriteAllText(@"C:\Users\User\Desktop\1.txt", lines);
        }
        public void SavePbi(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {
            string lines = " | " + textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text + " | " + textBox4.Text + " | " + textBox5.Text;
            System.IO.File.WriteAllText(@"C:\Users\User\Desktop\2.txt", lines);
        }
        public void WriteF(TextBox textBox1, TextBox textBox2)
        {
            textBox1.Text = File.ReadAllText(@"C:\Users\User\Desktop\1.txt");
            textBox2.Text = File.ReadAllText(@"C:\Users\User\Desktop\2.txt");
        }
    }
}
