using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LojaOnLine
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();
            p.nome = "Carro";
            p.criado = new DateTime(2023, 12, 1);
            p.custo = p.CalculaCusto();

            #region V1

            ArrayList produtos = new ArrayList();

            produtos.Add(p);

            //Gravar em ficheiro

            Stream s = File.Open("Produtos.txt", FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s,produtos);
            s.Close();

            produtos.Clear();


            s = File.Open("Produtos.dat", FileMode.Open);
            b = new BinaryFormatter();
            produtos = (ArrayList)b.Deserialize(s);
            s.Close();

            foreach(Produto po in produtos)
            {
                po.custo = po.CalculaCusto();
                Console.WriteLine($"Id: {po.id} - Nome:{po.nome} - Data: {po.criado} - Custo: {po.custo} ");
            }

            #endregion

            #region V2

            GereFIcheiroProdutos.GravaProdutos("ProdutosII.dat", produtos);
            
            produtos.Clear();

            produtos = GereFIcheiroProdutos.LoadProdutos("ProdutosII.dat");

            GereFIcheiroProdutos.Mostra(produtos);

            #endregion

            #region V3 - CORRECTA

            Produtos loja = new Produtos();
            loja.nomeLoja = "Pingo Doce";
            loja.produtos.Add(p);

            loja.GravaProdutos("ProdutosIII.dat");
            loja.produtos.Clear();
            Console.WriteLine("Após Clear\n");
            GereFIcheiroProdutos.Mostra(loja.produtos);

            loja.LoadProdutos("ProdutosIII.dat");
            Console.WriteLine("Após Load\n");
            GereFIcheiroProdutos.Mostra(loja.produtos);

            #endregion

            Console.WriteLine("Done!");
        }
    }
}
