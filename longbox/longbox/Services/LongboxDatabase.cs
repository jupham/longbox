using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using longbox.Models;
using SQLite;

namespace longbox.Services
{
    class LongboxDatabase : IComicDatabaseProvider
    {
        private SQLiteAsyncConnection db { get; set; }
        public LongboxDatabase()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "longbox.db");

            // Create database
            var dbSync = new SQLiteConnection(dbPath);
            CreateTables(dbSync);

            // Create async Connection
            db = new SQLiteAsyncConnection(dbPath);
        }

        private void CreateTables(SQLiteConnection db)
        {
            db.CreateTable<Comic>();
            db.CreateTable<Credit>();
            db.CreateTable<ComicCredit>();
            db.CreateTable<Page>();
        }

        public async Task<List<Comic>> GetComicsAsync()
        {
            var query = db.Table<Comic>();
            var result = await query.ToListAsync();
            return result;
        }

        public async Task<bool> WriteComicsAsync(List<Comic> comics)
        {
            foreach(Comic c in comics)
            {
                try
                {
                    await db.InsertAsync(c);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine("Unable to insert comic");
                    Debug.WriteLine(ex);
                }
            }

            return true;
        }
    }
}
