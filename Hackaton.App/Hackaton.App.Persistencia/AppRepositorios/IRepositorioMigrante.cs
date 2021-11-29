using System.Collections.Generic;
using System;
using System.Diagnostics;
using Hackaton.App.Dominio;

namespace Hackaton.App.Persistencia
{
public interface IRepositorioMigrantes
    {
    IEnumerable<Migrante> GetAllMigrante();
    Migrante AddMigrantes(Migrante migrante);
    void DeleteMigrantes(int id);

    Migrante GetMigrantes(int id);

    Migrante UpdateMigrantes(Migrante migrante);

    }

}
