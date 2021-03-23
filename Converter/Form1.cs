using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BConvert_Click(object sender, EventArgs e)
        {
            if (tBIn.Text == string.Empty)
            {
                MessageBox.Show("Enter value");
                return;
            }

        //DEC

            //DEC -> BIN
            if (rBIDec.Checked && rBOBin.Checked)
            {
                int decNumber = int.Parse(tBIn.Text);
                string binNumber = string.Empty;

                while (decNumber > 0)
                {
                    binNumber = decNumber % 2 + binNumber;
                    decNumber = decNumber / 2;
                }
                tBOut.Text = binNumber;
            }

            //DEC -> OCT
            if (rBIDec.Checked && rBOOct.Checked)
            {
                int decNumber = int.Parse(tBIn.Text);
                string octNumber = string.Empty;

                while (decNumber > 0)
                {
                    octNumber = decNumber % 8 + octNumber;
                    decNumber = decNumber / 8;
                }
                tBOut.Text = octNumber;
            }

            //DEC -> HEX
            if (rBIDec.Checked && rBOHex.Checked)
            {
                int decNumber = int.Parse(tBIn.Text);
                string hexNumber = string.Empty;
                int r = decNumber;

                while (decNumber > 0)
                {
                    r = decNumber % 16;

                    if (r < 10)
                    {
                        hexNumber = hexNumber.Insert(0, Convert.ToChar(r + 48).ToString());
                    }
                    else
                    {
                        hexNumber = hexNumber.Insert(0, Convert.ToChar(r + 55).ToString());
                    }
                    decNumber /= 16;
                }
                tBOut.Text = hexNumber.ToString();
            }

            //DEC -> DEC
            if (rBIDec.Checked && rBODec.Checked)
            {
                tBOut.Text = tBIn.Text;
            }

        //BIN

            //BIN -> DEC
            if (rBIBin.Checked && rBODec.Checked)
            {
                int binNumber = int.Parse(tBIn.Text);
                int decNumber = 0;
                int r = 1;

                while (binNumber > 0)
                {
                    int reminder = binNumber % 10;
                    binNumber = binNumber / 10;
                    decNumber += reminder * r;
                    r = r * 2;
                }
                tBOut.Text = decNumber.ToString();
            }

            //BIN -> OCT
            if (rBIBin.Checked && rBOOct.Checked)
            {
                string binNumber = tBIn.Text;
                int r = Convert.ToInt32(binNumber, 2);
                string octNumber = (Convert.ToString(r, 8));

                tBOut.Text = octNumber;
            }

            //BIN -> HEX
            if (rBIBin.Checked && rBOHex.Checked)
            {
                string binNumber = tBIn.Text;
                int r = Convert.ToInt32(binNumber, 2);
                string hexNumber = (Convert.ToString(r, 16));

                tBOut.Text = hexNumber;
            }

            //BIN -> BIN
            if (rBIBin.Checked && rBOBin.Checked)
            {
                tBOut.Text = tBIn.Text;
            }


        //OCT

            //OCT -> DEC
            if (rBIOct.Checked && rBODec.Checked)
            {
                int octNumber = int.Parse(tBIn.Text);
                int decNumber = 0;
                int r = 1;

                while (octNumber > 0)
                {
                    int reminder = octNumber % 10;
                    octNumber = octNumber / 10;
                    decNumber += reminder * r;
                    r = r * 8;
                }
                tBOut.Text = decNumber.ToString();
            }

            //OCT -> BIN
            if (rBIOct.Checked && rBOBin.Checked)
            {
                string octNumber = tBIn.Text;
                int r = Convert.ToInt32(octNumber, 8);
                string binNumber = (Convert.ToString(r, 2));

                tBOut.Text = binNumber;
            }

            //OCT -> HEX
            if (rBIOct.Checked && rBOHex.Checked)
            {
                string octNumber = tBIn.Text;
                int r = Convert.ToInt32(octNumber, 8);
                string hexNumber = (Convert.ToString(r, 16));

                tBOut.Text = hexNumber;
            }

            //OCT -> OCT
            if (rBIOct.Checked && rBOOct.Checked)
            {
                tBOut.Text = tBIn.Text;
            }

        //HEX

            //HEX -> DEC
            if (rBIHex.Checked && rBODec.Checked)
            {
                string hexNumber = tBIn.Text;
                int decNumber;

                decNumber = Int32.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);

                tBOut.Text = decNumber.ToString();
            }

            //HEX -> BIN
            if (rBIHex.Checked && rBOBin.Checked)
            {
                string hexNumber = tBIn.Text;
                int r = Convert.ToInt32(hexNumber, 16);
                string binNumber = (Convert.ToString(r, 2));

                tBOut.Text = binNumber;
            }

            //HEX -> OCT
            if (rBIHex.Checked && rBOOct.Checked)
            {
                string hexNumber = tBIn.Text;
                int r = Convert.ToInt32(hexNumber, 16);
                string octNumber = (Convert.ToString(r, 8));

                tBOut.Text = octNumber;
            }

            //HEX -> HEX
            if (rBIHex.Checked && rBOHex.Checked)
            {
                tBOut.Text = tBIn.Text;
            }
        }

    }
}
