using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToggleSwitchDemo.Classes;

namespace ToggleSwitchDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildFormButton_Click(object sender, EventArgs e)
        {
            
            var childForm = new ChildForm();
            childForm.ClickedEvent += ClickedEvent;

            try
            {
                childForm.ShowDialog();
            }
            finally
            {
                childForm.Dispose();
            }
        }

        private void ClickedEvent(OperationType operationType, bool state)
        {
            switch (operationType)
            {
                case OperationType.BPlusRelay:
                    // TODO
                    break;
                case OperationType.BMinusRelay:
                    // TODO
                    break;
                case OperationType.PreRelay:
                    // TODO
                    break;
                case OperationType.CycleCount:
                    // TODO
                    break;
                case OperationType.PairDown:
                    // TODO
                    break;
                case OperationType.TestMode:
                    // TODO
                    break;
                case OperationType.StandbyMode:
                    // TODO
                    break;

            }


        }
    }
}
