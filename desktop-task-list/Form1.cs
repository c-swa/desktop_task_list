using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_task_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Creating and setting the properties of the label
            Label lb = new Label();
            lb.Location = new Point(243, 80);
            lb.Text = "Task List View";

            // Adding Label control to the form
            this.Controls.Add(lb);

            // Creating and setting the properties of ListBox
            ListView listView = new ListView();
            listView.Location = new Point(246, 104);
            listView.Visible = true;
            listView.Items.Add("test 1");
            listView.Items.Add("test 2");
            listView.Items.Add("test 3");

            this.Controls.Add(listView);

        }
    }
}
