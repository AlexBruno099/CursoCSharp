using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.Classes_e_Metodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", Variaveis.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", interpolacao.Executar},
                
                {"Lendo dados - Fundamentos", lendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores aritméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos - Fundamentos", OperadoresLogicos1.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores unários - Fundamentos", OperadoresUnarios.Executar},

                // Estruturas de controle
                {"Estrutura If - Estruturas de controle", EstruturaIF.Executar},
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controle", estruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaDeSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura DO While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaDeFor.Executar},
                {"Estrutura For Each - Estruturas de controle", EstruturaDeForeach.Executar},
                {"Usando break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando continue - Estruturas de controle", UsandoContinue.Executar},

                // Classes e métodos
                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"Metodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Metodos estaticos - Classes e métodos", MembroEstaticos.Executar},
                {"Atributos Estáticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio atributos - Classes e métodos", DesafiosAtributos.Executar},
                {" Resposta Desafio atributos - Classes e métodos", RespostaDesafio.Executar},
                {"Params - Classes e métodos", Params.Executar},
                {"Parametros nomeados - Classes e métodos", ParametroNomeado.Executar},
                {"Get Set - Classes e métodos", GetSet.Executar},
                {"Props - Classes e métodos", Props.Executar},
                {"Enum - Classes e métodos", ExemploEnum.Executar},
                {"Struct Vs Classe - Classes e métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e métodos", ValorVsReferencia.Executar},
                {"Parametros por Referência - Classes e métodos", ParametrosPorReferencia.Executar},
                {"Parametro com valor padrão - Classes e métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", colecoes.Executar},
                {"List - Coleções", ColecoesList.Executar},
               
                // OO
                {"Heranca - OO", Heran.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Seale.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}