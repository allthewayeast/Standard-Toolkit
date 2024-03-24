﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace TestForm
{
    public partial class DataGridViewTest : KryptonForm
    {
        public DataGridViewTest()
        {
            InitializeComponent();
        }

        private void DataGridViewTest_Load(object sender, EventArgs e)
        {
            foreach (var style in Enum.GetNames(typeof(DataGridViewStyle)))
            {
                kcmbGridStyle.Items.Add(style);
            }

            kryptonDataGridView1.BorderStyle = BorderStyle.Fixed3D;

            DateTime dt = DateTime.Now.Date;
            dtTestData.Rows.Add(dt, "Mr", "Mark", "(55) 5555-5555", "Single", 36, "Press!", true);
            dtTestData.Rows.Add(dt, "Mrs", "Mary", "(01) 2345-6789", "Married", 21, "Press!", false);
            dtTestData.Rows.Add(dt, "Miss", "Mandy", "(03) 5555-1111", "Single", 44, "Press!", false);
            dtTestData.Rows.Add(dt, "Ms", "Mercy", "(99) 2211-2211", "Single", 25, "Press!", true);
            dtTestData.Rows.Add(dt, "Mr", "Micheal\r\nSingle\r\nMarried", "(07) 0070-0700", "Divorced", 35, "Press!", false);
            dtTestData.Rows.Add(dt, "Mrs", "Marge has a really long name normally, and this should wrap", "(10) 2311-2311", "Married", 80, "Press!", true);

            kryptonPropertyGrid1.SelectedObject = new KryptonDataGridViewProxy(kryptonDataGridView1);
        }
    }
}
