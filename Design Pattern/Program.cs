// See https://aka.ms/new-console-template for more information
using Design_Pattern.Buesiness.Factory_Method.Game;
using Design_Pattern.Buesiness.Factory_Method.Game.Example.DomainFactoryEnemy;
using Design_Pattern.Buesiness.Factory_Method.Game.Example.FactoryEnemy;
using Design_Pattern.Buesiness.Interface;
using System.Collections.Generic;

Console.WriteLine("Hello, World! Design Pattern!");

List<IPractice> practices = new List<IPractice>();
practices.Add(new ExNewEnemy());
practices.Add(new ExFactoryEnemy());
practices.Add(new ExDomainFactoryEnemy());

foreach (IPractice practice in practices)
{
    practice.Run((practice) => {
        Console.WriteLine("==================================================");
        Console.WriteLine($"Practice : {practice.Name()}");
        Console.WriteLine($"Description : {Environment.NewLine}{practice.Description()}");
        Console.WriteLine($"Disadvantage : {Environment.NewLine}{practice.Disadvantage()}");
        Console.WriteLine("==================================================");
    },(practice) => {
        Console.WriteLine("==================================================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    });
}





