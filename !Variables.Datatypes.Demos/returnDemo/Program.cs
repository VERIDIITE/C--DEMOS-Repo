﻿// double total = 0;
// double minimumSpend = 30.00;

// double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
// double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }

///////////////////////////////////(SECOND PART)

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    int rate = 23500;
    return vnd / rate;
}