using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroWindownsForm
{
    public partial class Form1 : Form
    {
        Funcionario model = new Funcionario();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            SetDataInGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            textNome.Text = textIdade.Text = textFuncao.Text = textSalario.Text = textCidade.Text = textEndereco.Text = textBairro.Text = string.Empty;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.FuncionarioId = 0;
        }

        void SetDataInGridView()
        {
            dgvdataGridView.AutoGenerateColumns = false;
            using (TutorialEntities db = new TutorialEntities())

            {
                dgvdataGridView.DataSource = db.Funcionarios.ToList<Funcionario>();

            }

        }

            private void btnSave_Click(object sender, EventArgs e)
        {
            model.FuncionarioNome = textNome.Text.Trim();
            model.FuncionarioIdade = Convert.ToInt32(textIdade.Text.Trim());
            model.FuncionarioFuncao = textFuncao.Text.Trim();
            model.FuncionarioSalario = Convert.ToDecimal(textSalario.Text.Trim());
            model.FuncionarioCidade = textCidade.Text.Trim();
            model.FuncionarioEndereco = textEndereco.Text.Trim();
            model.FuncionarioBairro = textBairro.Text.Trim();


            using (TutorialEntities db = new TutorialEntities())
            {
                if (model.FuncionarioId == 0) // inserir
                    db.Funcionarios.Add(model);
                else // update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
                    Clear();
                    SetDataInGridView();
                    MessageBox.Show("Registro Gravado com Sucesso!");     
            }

        private void dgvdataGridView_DoubleClick(object sender, EventArgs e)

        {
            if (dgvdataGridView.CurrentRow.Index != -1)
            {
                model.FuncionarioId = Convert.ToInt32(dgvdataGridView.CurrentRow.Cells["FuncionarioId"].Value);
                using (TutorialEntities db = new TutorialEntities())
                {
                    model = db.Funcionarios.Where(x => x.FuncionarioId == model.FuncionarioId).FirstOrDefault();
                    textNome.Text = model.FuncionarioNome;
                    textIdade.Text = model.FuncionarioIdade.ToString();
                    textFuncao.Text = model.FuncionarioFuncao;
                    textSalario.Text = model.FuncionarioSalario.ToString();
                    textCidade.Text = model.FuncionarioCidade;
                    textEndereco.Text = model.FuncionarioEndereco;
                    textBairro.Text = model.FuncionarioBairro;


                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você deseja deletar o Registro?", "Form1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
         using(TutorialEntities db = new TutorialEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State ==  EntityState.Detached)
                            db.Funcionarios.Attach(model);
                    db.Funcionarios.Remove(model);
                    db.SaveChanges();
                    SetDataInGridView();
                    Clear();
                    MessageBox.Show("Deletado com Sucesso");
                }
            }
        }
    }
}