using System;
using System.IO;
using System.Globalization;

namespace Ex15._01
{
    public class ArquivoCsv
    {
        static void Main(string[] args)
        {
            string CaminhoPath = @"C:\Users\leandrocandido\Desktop\Teste2\dados.csv";

            if (File.Exists(CaminhoPath))
            {
                try
                {
                    string folderPath = Path.Combine(Path.GetDirectoryName(CaminhoPath), "out");
                    string filePath = Path.Combine(folderPath, "summary.csv");

                    // Criar a pasta "out" se não existir
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    // Ler o arquivo de entrada
                    string[] LerArquivoCsv = File.ReadAllLines(CaminhoPath);

                    // Abrir o arquivo para escrita
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Nome,Valor Total"); // Cabeçalho do arquivo de saída

                        // Processar cada linha, ignorando a primeira (cabeçalho)
                        for (int i = 1; i < LerArquivoCsv.Length; i++)
                        {
                            string line = LerArquivoCsv[i];
                            string[] fields = line.Split(',');

                            if (fields.Length == 3 &&
                                decimal.TryParse(fields[1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price) &&
                                int.TryParse(fields[2], out int quantity))
                            {
                                string name = fields[0];
                                decimal totalValue = price * quantity;
                                writer.WriteLine($"{name},{totalValue.ToString("F2", CultureInfo.InvariantCulture)}");
                            }
                            else
                            {
                                Console.WriteLine($"Linha ignorada por dados inválidos: {line}");
                            }
                        }
                    }

                    Console.WriteLine($"Arquivo 'summary.csv' criado em: {filePath}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ocorreu um erro ao tentar processar o arquivo. {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo de entrada não encontrado. Verifique o caminho informado.");
            }
        }
    }
}
