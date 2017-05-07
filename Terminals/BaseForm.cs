using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminals
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            Font          = new Font(SystemFonts.MessageBoxFont.FontFamily, 9.0F);
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Font;
        }
    }
}
