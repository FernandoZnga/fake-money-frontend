using System;
using System.Windows.Forms;

namespace Frontend.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PinNumberLabel.Visible = false;
            PinNumber.Visible = false;
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("1");
            } else
            {
                PinNumber.AppendText("1");
            }
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("2");
            }
            else
            {
                PinNumber.AppendText("2");
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("3");
            }
            else
            {
                PinNumber.AppendText("3");
            }
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("4");
            }
            else
            {
                PinNumber.AppendText("4");
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("5");
            }
            else
            {
                PinNumber.AppendText("5");
            }
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("6");
            }
            else
            {
                PinNumber.AppendText("6");
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("7");
            }
            else
            {
                PinNumber.AppendText("7");
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("8");
            }
            else
            {
                PinNumber.AppendText("8");
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("9");
            }
            else
            {
                PinNumber.AppendText("9");
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.AppendText("0");
            }
            else
            {
                PinNumber.AppendText("0");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            PinNumber.Clear();
            CcNumber.Clear();
            RequestCcNumber();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                CcNumber.Clear();
            }
            else
            {
                PinNumber.Clear();
            }
        }

        private void RequestPinNumber ()
        {
            CcNumber.Visible = false;
            CcNumberLabel.Visible = false;
            PinNumber.Visible = true;
            PinNumberLabel.Visible = true;
        }

        private void RequestCcNumber()
        {
            CcNumber.Visible = true;
            CcNumberLabel.Visible = true;
            PinNumber.Visible = false;
            PinNumberLabel.Visible = false;
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (CcNumber.Visible)
            {
                RequestPinNumber();
            }
            else
            {
                //AsynchronousClient.StartClient(XmlSerialization.LoginData(CcNumber.Text, PinNumber.Text));
                SynchronousClient.StartClient(XmlSerialization.LoginData(CcNumber.Text, PinNumber.Text));

            }
        }
    }
}
