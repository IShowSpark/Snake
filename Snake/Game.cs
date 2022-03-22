using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Game
	{
		ConsoleKeyInfo key;
		public bool mus = true; //mus по умолчанию включена, но у меня не работает :(((((
		public int dif = 1; //по умолчанию сложность
		public int xOffset = 25; //по умолчанию меню расположение
		public int yOffset = 8; //по умолчанию меню расположение
		public string[] Main;
		public ConsoleColor[] colours = { ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Black, }; //это если не выбирать пресет, то ставится дефолтный как с видоса
		public char[] syms = { '*', '$', '+' }; //та самая дефолт настройка

		public void Menu()
		{
			Console.SetWindowSize(80, 25);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			do
			{
				Console.SetWindowSize(80, 25); //ставится размер окна
				Main = new string[] { "1 - Start", "2 - Settings", "3 - Difficulty", "4 - Quit" }; // вылазит меню выбора
				PrintMenu(Main, xOffset, yOffset); //позиция
				key = Console.ReadKey(true); //отвечает за кнопки
				if (key.Key == ConsoleKey.D1) //если нажата 1, то запускаем игру, то есть закрываем окно это меню и начинаем игру
				{
					break;
				}
				else if (key.Key == ConsoleKey.D2) //режим настроек при нажатии на цифру 2
				{
					Main = new string[] { "1 - Bebra1 Preset", "2 - Bebra2 Preset", "3 - Bebra3 Preset", "4 - Back" };
					Settings();
				}
				else if (key.Key == ConsoleKey.D3) //режим сложности при нажатии на цифру 3
				{
					Main = new string[] { "1 - Easy", "2 - Medium", "3 - Hard", "4 - Back" };
					Difficulty();
				}
				else if (key.Key == ConsoleKey.D4) //выход из игры
				{
					Console.Clear();
				}
			} while (true);
		}
		private void Settings() //метод настроек
		{
			do
			{
				PrintMenu(Main, xOffset, yOffset); //место расположение настроек
				key = Console.ReadKey(true); //опять же настраиваем кнопки
				if (key.Key == ConsoleKey.D1) //при нажатии на 1 ставится такой пресет
				{
					colours = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.White, ConsoleColor.Red }; //тут мы меняем цвет и т.п
					syms = new char[] { '-', '%', '.' };
				}
				else if (key.Key == ConsoleKey.D2) //так же при нажатии на цифру 2 ставится такой пресет
				{
					colours = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.White }; //тут мы меняем цвет и т.п
					syms = new char[] { '¤', '?', '#' };
				}
				else if (key.Key == ConsoleKey.D3) //при нажатии на цифру 3
				{
					colours = new ConsoleColor[] { ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.Black }; //тут мы меняем цвет и т.п
					syms = new char[] { '%', '*', '§' };
				}
				else if (key.Key == ConsoleKey.D4) //при нажатии на цифру 4 у нас возвращается назад все к меню
				{
					break;
				}
			} while (true);
		}
		public void Difficulty() //метод сложности
		{
			do
			{
				PrintMenu(Main, xOffset, yOffset); //расположение окна
				key = Console.ReadKey(true); //отвечает за кнопки
				if (key.Key == ConsoleKey.D1) //при нажатии на цифру 1, то будет первая сложность и так по аналогии дальше
				{
					dif = 1;
				}
				else if (key.Key == ConsoleKey.D2)
				{
					dif = 2;
				}
				else if (key.Key == ConsoleKey.D3)
				{
					dif = 3;
				}
				else if (key.Key == ConsoleKey.D4)
				{
					break;
				}

			} while (true);

		}
		public void WriteGameOver(int score) //в конце игры пишет game over
		{
			Console.SetWindowSize(80, 25); //создается окно после того как врезался в стенку
			Main = new string[] { "G A M E	O V E R", "Autor: Artjom Rozhkov", "", $"Your score is {score} " };
			PrintMenu(Main, xOffset, yOffset); //место расположение
		}

		public void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
		public void PrintMenu(string[] M, int xOffset, int yOffset)
		{
			Console.Clear();
			for (int i = 0; i < M.Length; i++)
			{
				WriteText(M[i], xOffset, yOffset++);
			}
			WriteText(M[0], xOffset, yOffset++);
		}
	}

}