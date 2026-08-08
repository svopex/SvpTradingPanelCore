using System;
using System.Collections.Generic;
using System.Text;

namespace Mt5Api
{
	public class MtApiBase
	{
		/// <summary>
		/// Pending order zadany nad aktualni cenou je buy stop (a sell limit),
		/// zadany pod aktualni cenou je buy limit (a sell stop).
		/// Pokud neni k dispozici aktualni cena, chovej se jako doposud (limit).
		/// </summary>
		protected static bool IsStopOrder(double price, double actualPrice, double units)
		{
			if (actualPrice <= 0)
			{
				return false;
			}
			return units > 0 ? price > actualPrice : price < actualPrice;
		}

		protected int CalculateCandlesFromSessionStart(int period)
		{
			int candles = CalculateCandlesFromSessionStartBase(period);
			if (candles < (60 / period))
			{
				candles = 60 / period; // svicek za posledni hodinu
			}
			return candles;
		}

		private int CalculateCandlesFromSessionStartBase(int period)
		{
			DateTime today = DateTime.UtcNow.Date;
			if (DateTime.UtcNow.Hour < 6)
			{
				today = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
				return (int)(DateTime.UtcNow - today).TotalMinutes / period;
			}
			else if (DateTime.UtcNow.Hour < 13 || (DateTime.UtcNow.Hour == 13 && DateTime.UtcNow.Minute < 30))
			{
				today = new DateTime(today.Year, today.Month, today.Day, 6, 0, 0);
				return (int)(DateTime.UtcNow - today).TotalMinutes / period;
			}
			else if (DateTime.UtcNow.Hour < 20)
			{
				today = new DateTime(today.Year, today.Month, today.Day, 13, 30, 0);
				return (int)(DateTime.UtcNow - today).TotalMinutes / period;
			}
			else
			{
				today = new DateTime(today.Year, today.Month, today.Day, 20, 00, 0);
				return (int)(DateTime.UtcNow - today).TotalMinutes / period;
			}
		}
	}
}
