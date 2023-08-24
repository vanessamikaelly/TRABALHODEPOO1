using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Cadastro_de_Livro

{
    public partial class Form1 : Form
    {
        List<Livro> livros = new List<Livro>();
        public Form1()
        {
           
            InitializeComponent();
            livros = Livro.LerArquivo();
            CarregarDados();


            // está chamando o método LerArquivo() da classe Livro para ler as informações dos livros
            // de um arquivo e armazena na lista livros
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            try
            {
                livro.Codigo = txt_codigo.Text;
                livro.Titulo = txt_titulo.Text;
                livro.Sinopse = txt_sinopse.Text;
                livro.Genero = cb_genero.Text;
                livro.Autor = txt_autor.Text;
                livro.Ano = txt_ano.Text;
                livro.Editora = txt_editora.Text;
                livro.Precoaquisicao = Convert.ToDouble(txt_valoraquisicao.Text);
                livro.Lucro = Convert.ToDouble(txt_lucro.Text);

                double calculo = (livro.Lucro / 100) * livro.Precoaquisicao;
                livro.Valorvenda = calculo + livro.Precoaquisicao;

                txt_valorvenda.Text = Convert.ToString(livro.Valorvenda);
                livros.Add(livro);

                if (livro.CadastrarLivro(livro))
                {
                    MessageBox.Show($"Livro salvo com sucesso.");

                    dataGrid_livro.DataSource = null;
                    dataGrid_livro.Refresh();
                    dataGrid_livro.DataSource = livros;

                }
                else
                {
                    MessageBox.Show("Erro ao salvar livro.");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato inválido!" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado!" + ex.Message);
            }
        }


        private void bt_limpar_Click_1(object sender, EventArgs e)
        {

            txt_codigo.Clear();
            txt_titulo.Clear();
            txt_sinopse.Clear();
            cb_genero.ResetText(); //limpa combobox
            txt_autor.Clear();
            txt_ano.Clear();
            txt_editora.Clear();
            txt_valoraquisicao.Clear();
            txt_lucro.Clear();
            txt_valorvenda.Clear();

        }

        private void CarregarDados()
         {
            dataGrid_livro.DataSource = null; // Remove a associação atual

            livros = Livro.LerArquivo(); // Lê os dados do arquivo e armazena na lista livros

            dataGrid_livro.DataSource = livros; // Associa a lista atualizada ao DataGridView



        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGrid_livro.CurrentCell.RowIndex;
                MessageBox.Show(index.ToString());


                livros.RemoveAt(index); //remover da lista

                dataGrid_livro.DataSource = null; //remover todos os elementos da linha

                dataGrid_livro.Refresh(); //ataulizar a tabela

                dataGrid_livro.DataSource = livros;
            }

       
            catch(FormatException ex)
            {
                MessageBox.Show("erro inesperado" +ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado" + ex.Message);



            }
        }

      
    }
}
