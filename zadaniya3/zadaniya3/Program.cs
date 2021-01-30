using System;

namespace Proger
{
	class Program
	{
		class Converter
		{

			double smn;
			public void SetSmn(double value)
			{
				smn = value;
			}
			public double GetSmn()
			{
				return smn;
			}
			double usd;
			public double GetUsd()
			{
				return usd;
			}
			double eur;
			public double GetEur()
			{
				return eur;
			}
			double rub;
			public double GetRub()
			{
				return rub;
			}
			public double nUsd;
			public void SetNUsd(double value)
			{
				nUsd = value;
			}
			public double GetNUsd()
			{
				return nUsd;
			}
			public double MethodUsd(double usd, double smn, double nUsd)
			{
				nUsd = usd * smn;
				return nUsd;
			}
			public double MethodEur(double eur, double smn, double nEur)
			{
				nEur = eur * smn;
				return nEur;
			}
			public double MethodRub(double rub, double smn, double nRub)
			{
				nRub = rub * smn;
				return nRub;
			}
			public Converter(double usd, double eur, double rub, double smn)
			{
				this.usd = usd;
				this.eur = eur;
				this.rub = rub;
				Console.Write("Введите сумму (somoni):");
				this.smn = Convert.ToDouble(Console.ReadLine());
			}

		}
		static void Main(string[] args)
		{
			Converter money = new Converter(11.32, 13.1, 0.48, 4);
			Console.WriteLine("Курси валют: ");

			money.MethodUsd(11.32, money.GetSmn(), 1);
			Console.WriteLine(money.MethodUsd(26.62, money.GetSmn(), 1));
			money.MethodEur(13.1, money.GetSmn(), 1);
			Console.WriteLine(money.MethodEur(29.61, money.GetSmn(), 1));
			money.MethodRub(0.48, money.GetSmn(), 1);
			Console.WriteLine(money.MethodRub(0.41, money.GetSmn(), 1));
			Console.ReadKey();
		}
	}
}
