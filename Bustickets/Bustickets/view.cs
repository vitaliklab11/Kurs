using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bustickets
{
    class view
    {
        public void registr(TextBox t1, TextBox t2, Button b1, Button b2) 
        {
            t1.Visible = false;
            t2.Visible = false;
            b1.Visible = false;
            b2.Visible = false;
        }
        public void registret(Label te1, Label te2, Label te3, Label te4, Label te5, TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5, Button bt1)
        {
            te1.Visible = true;
            te2.Visible = true;
            te3.Visible = true;
            te4.Visible = true;
            te5.Visible = true;
            tx1.Visible = true;
            tx2.Visible = true;
            tx3.Visible = true;
            tx4.Visible = true;
            tx5.Visible = true;
            bt1.Visible = true;
        }
        public void menreg(Label reg1, Label reg2, Label reg3, Label reg4, Label reg5, Label reg6, Label reg7, TextBox regt1, TextBox regt2, TextBox regt3, TextBox regt4, TextBox regt5, TextBox regt6, TextBox regt7, Button regb1, Button regb2, Button regb3, DataGridView dt1)
        {
            reg1.Visible = true;
            reg2.Visible = true;
            reg3.Visible = true;
            reg4.Visible = true;
            reg5.Visible = true;
            reg6.Visible = true;
            reg7.Visible = true;
            regt1.Visible = true;
            regt2.Visible = true;
            regt3.Visible = true;
            regt4.Visible = true;
            regt5.Visible = true;
            regt6.Visible = true;
            regt7.Visible = true;
            regb1.Visible = true;
            regb2.Visible = true;
            regb3.Visible = true;
            dt1.Visible = true;
        }
        public void registerhide(Label te1, Label te2, Label te3, Label te4, Label te5, TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4, TextBox tx5, Button bt1)
          {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = false;
            te5.Visible = false;
            tx1.Visible = false;
            tx2.Visible = false;
            tx3.Visible = false;
            tx4.Visible = false;
            tx5.Visible = false;
            bt1.Visible = false;
        }
        public void polkaz(TextBox txp1, TextBox txp2, TextBox txp3, TextBox txp4, TextBox txp5, DataGridView dat1)
        {
            txp1.Text = dat1.CurrentRow.Cells[0].Value.ToString();
            txp2.Text = dat1.CurrentRow.Cells[1].Value.ToString();
            txp3.Text = dat1.CurrentRow.Cells[2].Value.ToString();
            txp4.Text = dat1.CurrentRow.Cells[3].Value.ToString();
            txp5.Text = dat1.CurrentRow.Cells[4].Value.ToString();
        }
        public void oforml(Label of1, Label of2, Label of3, Label of4, Label of5, Label of6, TextBox off1, TextBox off2, TextBox off3, TextBox off4, TextBox off5, Button ofor1)
        {
            of1.Visible = true;
            of2.Visible = true;
            of3.Visible = true;
            of4.Visible = true;
            of5.Visible = true;
            of6.Visible = true;
            off1.Visible = true;
            off2.Visible = true;
            off3.Visible = true;
            off4.Visible = true;
            off5.Visible = true;
            ofor1.Visible = true;
        }
        public void reghide(Label reg1, Label reg2, Label reg3, Label reg4, Label reg5, Label reg6, Label reg7, TextBox regt1, TextBox regt2, TextBox regt3, TextBox regt4, TextBox regt5, TextBox regt6, TextBox regt7, Button regb1, Button regb2, Button regb3, DataGridView dt1)
        {
            reg1.Visible = false;
            reg2.Visible = false;
            reg3.Visible = false;
            reg4.Visible = false;
            reg5.Visible = false;
            reg6.Visible = false;
            reg7.Visible = false;
            regt1.Visible = false;
            regt2.Visible = false;
            regt3.Visible = false;
            regt4.Visible = false;
            regt5.Visible = false;
            regt6.Visible = false;
            regt7.Visible = false;
            regb1.Visible = false;
            regb2.Visible = false;
            regb3.Visible = false;
            dt1.Visible = false;
        }
        public void oformlhide(Label of1, Label of2, Label of3, Label of4, Label of5, Label of6, TextBox off1, TextBox off2, TextBox off3, TextBox off4, TextBox off5, Button ofor1)
        {
            of1.Visible = false;
            of2.Visible = false;
            of3.Visible = false;
            of4.Visible = false;
            of5.Visible = false;
            of6.Visible = false;
            off1.Visible = false;
            off2.Visible = false;
            off3.Visible = false;
            off4.Visible = false;
            off5.Visible = false;
            ofor1.Visible = false;
        }
        public void prosm(Label lb1, TextBox tex1, TextBox tex2, Button bat1, Button bat2,Button bat3)
        {
            lb1.Visible = true;
            tex1.Visible = true;
            tex2.Visible = true;
            bat1.Visible = true;
            bat2.Visible = true;
            bat3.Visible = true;
        }
        public void prosmhide(Label lb1, TextBox tex1, TextBox tex2, Button bat1, Button bat2, Button bat3)
        {
            lb1.Visible = false;
            tex1.Visible = false;
            tex2.Visible = false;
            bat1.Visible = false;
            bat2.Visible = false;
            bat3.Visible = false;
        }
    }
}
