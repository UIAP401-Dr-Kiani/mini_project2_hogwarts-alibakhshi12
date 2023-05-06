using System.Collections.Generic;

namespace Hagwartz;

public class listOfAuthorizedPersons
{
    private List<authorizedPersons> authorizedPersonsList = new List<authorizedPersons>();

    public List<authorizedPersons> AuthorizedPersonsList
    {
        get => authorizedPersonsList;
        set => authorizedPersonsList = value;
    }

    public listOfAuthorizedPersons()
    {
        this.AuthorizedPersonsList = Program.authorizedPersonsDetector();
    }
}