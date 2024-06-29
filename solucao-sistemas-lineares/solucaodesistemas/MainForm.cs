using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace solucaodesistemas
{
    public partial class MainForm : Form
    {
        private TextBox[,] mTextBoxes = new TextBox[3, 4];

        public MainForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
            ConfigureTitleLabel();
        }

        private void ConfigureTitleLabel()
        {
            TitleLabel.Text = "Solução de Sistemas Lineares";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter; // ajustando o alinhamento do texto conforme necessário
            TitleLabel.Font = new Font("Arial", 10, FontStyle.Bold); // ajustando a fonte e o tamanho conforme necessário
            TitleLabel.BackColor = Color.Thistle; // ajustando a cor de fundo conforme necessário
        }
        private void InitializeTextBoxes()
        {
            int textBoxMargin = 20; // margem entre a label e as textboxes

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(20 + j * 60, TitleLabel.Bottom + textBoxMargin + i * 30); // Ajusta a coordenada Y para titleLabel.Bottom + textBoxMargin
                    textBox.Size = new System.Drawing.Size(50, 20);
                    textBox.Name = $"m{i}{j}TextBox";
                    Controls.Add(textBox);
                    mTextBoxes[i, j] = textBox;
                }
            }
        }


        private List<List<double>> ColetarMatriz()
        {
            List<List<double>> matriz = new List<List<double>>();

            for (int i = 0; i < 3; i++)
            {
                List<double> linha = new List<double>();
                for (int j = 0; j < 4; j++)
                {
                    double valor;
                    if (!double.TryParse(mTextBoxes[i, j].Text, out valor))
                    {
                        MessageBox.Show("Por favor, insira apenas números válidos.");
                        return null;
                    }
                    linha.Add(valor);
                }
                matriz.Add(linha);
            }

            return matriz;
        }

        private void ResolverButton_Click(object sender, EventArgs e)
        {
            List<List<double>> matriz = ColetarMatriz();

            if (matriz == null)
                return;

            foreach (var linha in matriz)
            {
                foreach (var elemento in linha)
                {
                    if (elemento == 0)
                    {
                        ResultadoLabel.Text = "Erro: Todos os campos devem ser preenchidos.";
                        return;
                    }
                }
            }

            EliminacaoGaussJordan(matriz);
            string resultado = ClassificarSolucao(matriz);

            if (resultado == "Solução única")
            {
                List<double> solucao = CalcularSolucao(matriz);
                ResultadoLabel.Text = $"Resultado: {resultado}\n x = {solucao[0]}\n y = {solucao[1]}\n z = {solucao[2]}";
            }
            else
            {
                ResultadoLabel.Text = $"Resultado: {resultado}";
            }
        }

        private void EliminacaoGaussJordan(List<List<double>> matriz)
        {
            int n = matriz.Count;

            for (int i = 0; i < n; i++)
            {
                int linhaMax = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matriz[k][i]) > Math.Abs(matriz[linhaMax][i]))
                    {
                        linhaMax = k;
                    }
                }
                List<double> temp = matriz[i];
                matriz[i] = matriz[linhaMax];
                matriz[linhaMax] = temp;

                for (int k = i + 1; k < n; k++)
                {
                    double fator = matriz[k][i] / matriz[i][i];
                    for (int j = i; j < n + 1; j++)
                    {
                        matriz[k][j] -= fator * matriz[i][j];
                    }
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    double fator = matriz[k][i] / matriz[i][i];
                    matriz[k][n] -= fator * matriz[i][n];
                    matriz[k][i] = 0;
                }
            }
        }

        private string ClassificarSolucao(List<List<double>> matriz)
        {
            int n = matriz.Count;
            bool linhaZero, inconsistente = false, dependente = false;

            for (int i = 0; i < n; i++)
            {
                linhaZero = matriz[i].Take(n).All(val => val == 0);
                if (linhaZero && matriz[i][n] != 0)
                {
                    inconsistente = true;
                    break;
                }
                else if (linhaZero && matriz[i][n] == 0)
                {
                    dependente = true;
                }
            }

            if (inconsistente)
            {
                return "nenhuma solução (sistema impossível)";
            }
            else if (dependente)
            {
                return "infinitas soluções";
            }
            else
            {
                return "solução única";
            }
        }

        private List<double> CalcularSolucao(List<List<double>> matriz)
        {
            int n = matriz.Count;
            List<double> solucao = new List<double>(new double[n]);

            for (int i = n - 1; i >= 0; i--)
            {
                double soma = matriz[i][n];
                for (int j = i + 1; j < n; j++)
                {
                    soma -= matriz[i][j] * solucao[j];
                }
                solucao[i] = soma / matriz[i][i];
            }

            return solucao;
        }

        
    }
    }

