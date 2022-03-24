using Data.ApplicationContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Services;
using System;
using System.Linq;

namespace Tests.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseService baseService = new BaseService(new MusicDbContext());
            var res=baseService.GetAll();
        //   MusicDbContext context=new MusicDbContext();

        //    var allPeshoSongs = context.ArtistSongs.Where(x => x.ArtistId == "6bc9b0c0-7cbd-4e90-abcf-16a3a04b6d05").Include(x => x.Song).Include(x => x.Artist).Select(x => new
        //    {
        //        ArtistName=x.Artist.ArtistName,
        //        ArtistSong=x.Song.SongName,
        //        ReleaseDate=x.Song.ReleaseDate,
        //        Time=x.Song.Seconds
        //    }).ToList();
            //Song song = new Song()
            //{
            //    SongName = "Hello",
            //    ReleaseDate = 2020,
            //    Seconds = 180
            //};

            //Artist artist = context.Artists.First();
            //ArtistSong artistSong = new ArtistSong()
            //{
            //    Song=song,
            //    Artist=artist,
            //    ArtistId=artist.Id,
            //    SongId=song.Id,
            //};
         
            //artist.ArtistSongs.Add(artistSong);

            //context.SaveChanges();

            //var artists = context.Artists.ToList();
            //Artist artist=new Artist();
            //artist.ArtistName = "Pesho";
            //artist.Biography = "Hello world";
            //artist.Id = Guid.NewGuid().ToString();

            //context.Artists.Add(artist);
            //context.SaveChanges();


        }
    }
}
