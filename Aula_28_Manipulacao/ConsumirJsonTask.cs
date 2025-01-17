using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aula_28_Manipulacao
{
    public class ConsumirJsonTask
    {
        static async Task Main(string[] args){
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";
            
            string nomeArquivo = "animes.txt";
            try{
                using(HttpClient client = new HttpClient()){
                    var response = await client.GetAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();

                    using(JsonDocument document = JsonDocument.Parse(responseString)){
                        var animeLissta = document.RootElement.GetProperty("data");

                        SalvarEmTxt(animeLissta, nomeArquivo);

                    }

                }

            }catch(Exception e){
                Console.WriteLine("Erro: " + e.Message);
            }

            static void SalvarEmTxt(JsonElement animelist, string nomeArquivo){
                try{
                    using(StreamWriter writer = new StreamWriter(nomeArquivo)){
                        foreach(var anime in animelist.EnumerateArray()){
                            string titulo = anime.GetProperty("title").GetString() ?? "Sem Titulo";
                            string types = anime.GetProperty("type").GetString() ?? "Sem Tipo";
                            string status = anime.GetProperty("status").GetString()?? "Sem Status";
                            string episodes = anime.GetProperty("episodes").GetInt32().ToString()?? "Sem Episodios";
                            
                        }
                    }
                    string season = "N/A";
                    int yar =  0;
                    if(animelist.TryGetProperty("animeSeason", out JsonElement seasonElement)){
                        season = animeSeason.TryGetProperty("season").GetString() ?? 'N/A';
                        if(seasonElement.TryGetProperty("year", out JsonElement yearElement)){
                            yar = yearElement.GetInt32();
                        }
                    }
                }catch(Exception e){
                    Console.WriteLine("Erro: " + e.Message);
                }
            }
        }
    }
}