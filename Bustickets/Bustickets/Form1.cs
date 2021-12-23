using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Bustickets
{
    public partial class Form1 : Form
    {
        view view = new view();
        controller controller = new controller();

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wasg, int wparam, int lparam);

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            controller.vhod(txtpass, txtuser);
            if(controller.switcher == 1)
            {
                view.menreg(label16, label15, label11, label6, label8, label9, label10, textBox11, textBox10, textBox9, textBox8, textBox5, textBox6, textBox7, button5, button4, button3, dataGridView1);
                view.registr(txtuser, txtpass, btnlogin, button1);
            }
            else
            {
                MessageBox.Show("Не вірний логін або пароль");
            }
        }

        private void btnerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view.registr(txtuser, txtpass, btnlogin, button1);
            view.registret(label7, label1, label3, label4, label5, textBox1, textBox4, textBox2, textBox3, txtpass1, button2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.podckl(textBox1, textBox2, textBox3, txtpass1);

            view.menreg(label16, label15, label11, label6, label8, label9, label10, textBox11, textBox10, textBox9, textBox8, textBox5, textBox6, textBox7, button5, button4, button3, dataGridView1);
            view.registerhide(label7, label1, label3, label4, label5, textBox1, textBox4, textBox2, textBox3, txtpass1, button2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controller.search(textBox11, textBox10, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view.oforml(label22, label20, label19, label18, label17, label12, textBox16, textBox15, textBox14, textBox13, textBox12, button6);
            view.reghide(label16, label15, label11, label6, label8, label9, label10, textBox11, textBox10, textBox9, textBox8, textBox5, textBox6, textBox7, button5, button4, button3, dataGridView1);

            controller.SaveText(textBox9, textBox8, textBox5, textBox6, textBox7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controller.rozklad(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            view.polkaz(textBox9, textBox8, textBox5, textBox6, textBox7, dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            view.oformlhide(label22, label20, label19, label18, label17, label12, textBox16, textBox15, textBox14, textBox13, textBox12, button6);
            controller.SavePbi(textBox16, textBox15, textBox14, textBox13, textBox12);
            view.prosm(label13, textBox18, textBox17, button8, button7, button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            controller.WriteF(textBox18, textBox17);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\User\Desktop\1.txt");
            File.Create(@"C:\Users\User\Desktop\1.txt");
            File.Delete(@"C:\Users\User\Desktop\2.txt");
            File.Create(@"C:\Users\User\Desktop\2.txt");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            view.prosmhide(label13, textBox18, textBox17, button8, button7, button9);
            view.menreg(label16, label15, label11, label6, label8, label9, label10, textBox11, textBox10, textBox9, textBox8, textBox5, textBox6, textBox7, button5, button4, button3, dataGridView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
