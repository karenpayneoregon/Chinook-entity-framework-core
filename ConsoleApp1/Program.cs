using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ChinookLibrary.Data;
using ChinookLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HousesOfTheHoly();
        }

        private static void HousesOfTheHoly()
        {
            using var context = new ChinookContext();
            var housesOfTheHoly = context
                .Album
                .Include(album => album.Artist)
                .Include(album => album.Track)
                .ThenInclude(track => track.Genre)
                .FirstOrDefault(album => album.AlbumId == 129);


            foreach (var track in housesOfTheHoly.Track)
            {
                Debug.WriteLine($"{track.Name,-40}{track.Time()}");
            }
        }
    }
}
