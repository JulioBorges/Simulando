using System;
using System.ComponentModel;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using CustomControls.Data;

namespace Simulando.UI
{
    public partial class FrmCadCategoria : Form
    {
        public FrmCadCategoria()
        {
            InitializeComponent();
        }

        private void CarregaDados(bool Loading)
        {
            try
            {
                categoriaTableAdapter.Fill(simulandoDBDataSet.Categoria);
                tableAdapterManager.UpdateAll(simulandoDBDataSet);

                if (Loading)
                    categoriaBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os dados.\nDetalhes: " + ex.Message);
            }
        }

        private void FrmCadCategoria_Load(object sender, EventArgs e)
        {
            CarregaDados(true);
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            txtId.Text = categoriaTableAdapter.GetId() == null ? "1" : Convert.ToString(categoriaTableAdapter.GetId());
            Refresh();
        }

        private void categoriaBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
           HabilitaComponentesEdicao(true);
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            var posicao = categoriaBindingSource.Position;
            CarregaDados(false);
            categoriaBindingSource.Position = posicao;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (categoriaBindingSource.Count > 0)
                HabilitaComponentesEdicao(true);
        }

        void HabilitaComponentesEdicao(bool habilitar)
        {
            txtDescricao.Enabled = habilitar;

            //BindingNavigator
            buttonAtualizar.Enabled = !habilitar;
            buttonEditar.Enabled = !habilitar;
            buttonCancelar.Enabled = habilitar;
            buttonSalvar.Enabled = habilitar;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            categoriaBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(simulandoDBDataSet);
            HabilitaComponentesEdicao(false);
            Mensagem.Aviso(this, "Categoria salva com sucesso !");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            categoriaBindingSource.CancelEdit();
            HabilitaComponentesEdicao(false);
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (categoriaBindingSource.Count > 0)
            {
                if (Mensagem.Pergunta(this,
                                      string.Format(
                                          "Deseja realmente excluir esta categoria?{0}OBS.: Não será possível excluir a categoria se a mesma estiver sendo utilizada !",
                                          Environment.NewLine), DialogResult.No))
                    return;
                try
                {
                    categoriaBindingSource.RemoveCurrent();
                    Validate();
                    categoriaBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(simulandoDBDataSet);
                    HabilitaComponentesEdicao(false);
                }
                catch (SqlCeException ex)
                {
                    if (ex.NativeError == 25025)
                        Mensagem.Erro(this, "Impossível excluir a categoria, pois existem questões cadastradas com esta categoria !");
                    else
                        Mensagem.Excecao(this, ex);
                }
                catch (Exception exc)
                {
                    Mensagem.Excecao(this, "Erro ao excluir o registro !", exc);
                }
            }
        }
    }
}
