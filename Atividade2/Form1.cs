using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {

        }
    }
    
    class Aluno
    {
        //Atributos
        public string Nome;
        private int Documento;
        public int RegistroMatricula;
        public string Turma;

        //Métodos
        public void nota()
        {

        }
        public void AssitirAula()
        {

        }
        public double media()
        {
            return 0;
        }

    }
}
