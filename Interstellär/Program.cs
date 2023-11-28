// See https://aka.ms/new-console-template
// for more information
using Interstellär.Data;
using Interstellär.Models;

Console.WriteLine("Hello, World!");


using (var context = new InterstellärDbContext())
{
    var uow = new InterstellärUnitOfWork(context);
    var planets = await uow.PlanetRepository.GetAllAsync();

    foreach (var planet in planets)
    {
        Console.WriteLine($"{planet.PlanetId}. {planet.Name}");
    }


    Console.WriteLine("Select a planet to visit by writing the corresponding planet number:");
    int selectedPlanetId = int.Parse(Console.ReadLine());

    if (selectedPlanetId != null)
    {


        VisitModel newVisit = new()
        {
            PlanetId = selectedPlanetId,
            Date = DateTime.Now,
        };

        uow.VisitRepository.Add(newVisit);
        uow.VisitRepository.Complete();
        Console.WriteLine("Visit saved");
    }

    else
    {
        Console.WriteLine("Invalid input");
    }




}