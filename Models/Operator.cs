using System.Diagnostics;

namespace Buses.Models;

public record Operator
{
#nullable enable
    private string? Route { get; set; }
    private string? Bus { get; set; }
#nullable disable

    public Operator()
    {
    }

    public Operator SetRoute(string route)
    {
        this.Route = route;

        Debug.WriteLine($"SetRoute: {route}");

        return this;
    }

    public Operator SetBus(string bus)
    {
        this.Bus = bus;

        Debug.WriteLine($"SetBus: {bus}");

        return this;
    }

    public Operator Submit()
    {
        if (Route is null || Bus is null)
            throw new Exceptions.NothingToSubmitException("Нужно выбрать маршрут и автобус");

        Debug.WriteLine("Submit");

        return this;
    }
}