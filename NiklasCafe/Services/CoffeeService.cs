﻿using NiklasCafe.Models;

namespace NiklasCafe.Services;

public class CoffeeService
{
    public event Action<Ingredient> CoffeeDone;

    public async Task PrepareCoffee()
    {
        Console.WriteLine("Coffee is brewing...");
        await Task.Delay(4000);
        var coffee = new Ingredient() {Name = "Coffee"};
        CoffeeDone.Invoke(coffee);
    }
}