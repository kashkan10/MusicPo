using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;

namespace MusicPortal.Models
{
    public class SongContext:DbContext
    {
        public DbSet<Song> Songs { get; set; }
    }

    public class SongDbInitializer: DropCreateDatabaseAlways<SongContext>
    {
        protected override void Seed(SongContext context)
        {
            context.Songs.Add(new Song { Title = "Седая ночь", Singer = "Шатунов", Duration = "5:20", Text = File.ReadAllText(HostingEnvironment.MapPath("/Texts/Сн.txt"), Encoding.Default).ToString() });
            context.Songs.Add(new Song { Title = "Leave a light on", Singer = "Tom Walker", Duration = "3:04", Text=File.ReadAllText(HostingEnvironment.MapPath("/Texts/Lalo.txt")).ToString()});
            context.Songs.Add(new Song { Title = "Fire In Me", Singer = "John Newman", Duration = "4:05", Text = File.ReadAllText(HostingEnvironment.MapPath("/Texts/Fim.txt")).ToString() });
            context.Songs.Add(new Song { Title = "The Road", Singer = "Flying Decibels", Duration = "3:05", Text = File.ReadAllText(HostingEnvironment.MapPath("/Texts/Tr.txt")).ToString() });
            context.Songs.Add(new Song { Title = "Carry you home", Singer = "James Blunt", Duration = "3:54" });
            context.Songs.Add(new Song { Title = "Say it", Singer = "Blue October", Duration = "3:47" });
            context.Songs.Add(new Song { Title = "Let it show", Singer = "K-Maro", Duration = "4:13" });
            context.Songs.Add(new Song { Title = "Белые розы", Singer = "Шатунов", Duration = "5:40" });

            base.Seed(context);
        }
    }
}