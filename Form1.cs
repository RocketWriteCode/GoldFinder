using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldFinder.EntitySystem;

namespace GoldFinder
{
    public partial class Form1 : Form
    {
        EntityManager entityManager;

        public Form1()
        {
            InitializeComponent();
            entityManager = new EntityManager();
        }
    }
}
