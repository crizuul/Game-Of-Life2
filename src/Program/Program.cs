//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    /// <summary>
    /// Coordina la ejecución del juego.
    ///
    /// SRP: la responsabilidad de esta clase es coordinar
    /// las diferentes partes del juego, sin encargarse de
    /// leer archivos, calcular generaciones o imprimir el tablero.
    ///
    /// Expert: Program conoce los objetos necesarios para ejecutar
    /// el juego y coordina la colaboración entre ellos.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location);
            string boardPath = Path.Combine(folder, "board.txt");
            // Reemplaza 👇 esta línea con tu código
            
            BoardReader reader = new BoardReader();
            Board board = reader.Read(boardPath);

            Generation generation = new Generation();
            ConsolePrinter printer = new ConsolePrinter();

            while (true)
            {
                Console.Clear();

                printer.Print(board);

                board = generation.Next(board);

                Thread.Sleep(300);
            }
        }
    }
}