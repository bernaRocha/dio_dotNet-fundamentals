/* O calendário escolar está passando bem rápido, devido a isso, 
as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. 
Visando em resolver a situação, a diretora da escola contratou você para desenvolver um programa 
que leia as notas da primeira e da segunda avaliação de um aluno. Calcule e imprima a média semestral.

O programa só aceitará notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
Cada nota deve ser validada separadamente.

No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, 
solicitando as professoras que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo 
novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução 
de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.
*/

using System;

class Desafio {
   private static void Main()
   {
      Main("media = ");
   }

   static void Main(string v) {
    //declare suas variaveis corretamente

        int notasRegistradas = 0; // ao iniciar não há notas para calcular
        bool opcaoNovoCalculo;    // iniciar ou não um novo cálculo
        double aux = 0;
        
        //continue a solução ou implemente da sua maneira
        
        while (notasRegistradas < 2) {            // no máximo 2 notas por média
          opcaoNovoCalculo = true;
          double nota = double.Parse(Console.ReadLine()); // registra a nota individua
          
          if (nota < 0 || nota > 10) {
            Console.WriteLine("nota invalida");   // notas é a nota registrada pelo usuário
          } else if (notasRegistradas == 0) {     // se só tiver uma nota no array notas
            aux = nota;                           // aux recebe nota
            notasRegistradas++;                   // incrementa o array de notas
          
          } else if (notasRegistradas == 1) {  // tendo duas notas registradas no array de notas
            double media = (aux + nota) / 2;     // media é igual a aux que recebe a primeira nota + a nota 2 e divide por 2

            Console.Write();
            Console.WriteLine(media.ToString("N2"));
            
            while (opcaoNovoCalculo == true){
              Console.WriteLine("novo calculo (1-sim 2-nao)");
              double res = double.Parse(Console.ReadLine());
	
              if (res == 1) {
               opcaoNovoCalculo = false;
               notasRegistradas = 0;
              } 
              else if (res == 2) {
              opcaoNovoCalculo = true;
              notasRegistradas++;
              }
            }
          } 
        }
    }
}