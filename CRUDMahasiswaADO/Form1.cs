using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class FormMahasiswa : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-66RNUT1U\\NAMAKUISAN;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public FormMahasiswa()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }
        