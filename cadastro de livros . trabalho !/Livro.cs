using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

public class Livro
{
    public string Codigo { get; set; } //chamamos as propiedades dentro de um get set que encapsula várias propriedades que armazenam informações sobre o livro
    public string Titulo { get; set; }
    public string Sinopse { get; set; }
    public string Genero { get; set; }
    public string Autor { get; set; }
    public string Ano { get; set; }
    public string Editora { get; set; }
    public double Precoaquisicao { get; set; }
    public double Lucro { get; set; }
    public double Valorvenda { get; set; }

    
    public Livro()
    {

    }

    public bool CadastrarLivro(Livro livro) //funcao chamada cadastrarLivro que recebe um objeto do tipo livro e retorna bool  
    {
        /*StreamWriter tem métodos para escrever caracteres em fluxos de saída, como arquivos.
        Ele é usado para criar e escrever em arquivos de texto*/

        //File.AppendText: Este é um método estático da classe File


        /*StreamWriter para escrever no escrever.*/

        //File.AppendText acrecenta texto ao nosso arquivo

        //File.AppendText ta concertando o erro que só atualizava, agora ele acrecenta e não reescreve

  
        try
        {
            string caminhoArquivo = ("C:\\Users\\vanes\\OneDrive\\2 B IFRO\\LIVROS\\trabalhopoo.docx"); //define o caminho para acesssar o codigo

            using (StreamWriter arquivo = File.AppendText((caminhoArquivo))) //define o caminho para acesssar o codigo, onde entramos definitivamente no nosso arquivo   //parâmetro passado para o método File.AppendText
            {
               
                arquivo.WriteLine($"{livro.Codigo} | {livro.Titulo} | {livro.Sinopse} | {livro.Genero} | {livro.Autor} | {livro.Ano} | {livro.Editora} | {livro.Precoaquisicao} | {livro.Lucro} | {livro.Valorvenda}");

            }

        }

        catch (Exception ex)
        {
            MessageBox.Show("Erro ao salvar o livro" + ex.Message); //caso aconteça erro
            return  false;




        }
        return true;

    }


    public static List<Livro> LerArquivo()
    {
        List<Livro> livros = new List<Livro>();

        using (StreamReader sr = new StreamReader("C:\\Users\\vanes\\OneDrive\\2 B IFRO\\LIVROS\\trabalhopoo.docx"))
        {
            string linha;

            while ((linha = sr.ReadLine()) != null) // Lê cada linha do arquivo
            {
                string[] partesdaLinha = linha.Split(' ');

                if (partesdaLinha.Length >= 10)
                {
                    Livro v = new Livro();

                    v.Codigo = partesdaLinha[0];
                    v.Titulo = partesdaLinha[1];
                    v.Sinopse = partesdaLinha[2];
                    v.Genero = partesdaLinha[3];
                    v.Autor = partesdaLinha[4];
                    v.Ano = partesdaLinha[5];
                    v.Editora = partesdaLinha[6];

                    double valorVenda;
                    double lucro;
                    double precoAquisicao;

                    if (double.TryParse(partesdaLinha[7], out valorVenda))
                    {
                        v.Valorvenda = valorVenda;

                        if (double.TryParse(partesdaLinha[8], out lucro))
                        {
                            v.Lucro = lucro;
                        }
                        if (double.TryParse(partesdaLinha[9], out precoAquisicao))
                        {
                            v.Precoaquisicao = precoAquisicao;
                        }
                    }

                    livros.Add(v);
                }
            }
        }

        return livros;



    }
 }


