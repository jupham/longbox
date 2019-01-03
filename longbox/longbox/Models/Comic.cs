using RestSharp.Deserializers;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace longbox.Models
{
    public class Comic
    {
        [DeserializeAs(Name = "id")]
        [PrimaryKey]
        public long Id { get; set; }

        [DeserializeAs(Name = "added_date")]
        public DateTime AddedDate { get; set; }

        [DeserializeAs(Name = "archive_type")]
        public String ArchiveType { get; set; }

        [DeserializeAs(Name = "base_filename")]
        [MaxLength(500)]
        public String BaseFilename { get; set; }

        [DeserializeAs(Name = "blocked_page_count")]
        public int BlockedPageCount { get; set; }

        [DeserializeAs(Name = "characters")]
        [Ignore]
        public List<string> ServerCharacters { get; set; } // This prop used when data comes from server. Database items use Characters prop

        [DeserializeAs(Name = "comic_vine_id")]
        public long ComicVineId { get; set; }

        [DeserializeAs(Name = "comic_vine_url")]
        [MaxLength(500)]
        public string ComicVineURL { get; set; }

        [DeserializeAs(Name = "cover_date")]
        public string CoverDate { get; set; }

        [DeserializeAs(Name = "deleted_page_count")]
        public int DeletedPageCount { get; set; }

        [DeserializeAs(Name = "description")]
        [MaxLength(1500)]
        public string Description { get; set; }

        [DeserializeAs(Name = "filename")]
        [MaxLength(500)]
        public string Filename { get; set; }

        [DeserializeAs(Name = "format")]
        public string format { get; set; }

        [DeserializeAs(Name = "imprint")]
        public string Imprint { get; set; }

        [DeserializeAs(Name = "issue_number")]
        public int IssueNumber { get; set; }

        [DeserializeAs(Name = "last_read_date")]
        public DateTime LastReadDate { get; set; }

        [DeserializeAs(Name = "missing")]
        public bool Missing { get; set; }

        [DeserializeAs(Name = "notes")]
        [MaxLength(500)]
        public string Notes { get; set; }

        [DeserializeAs(Name = "page_count")]
        public int PageCount { get; set; }

        [DeserializeAs(Name = "publisher")]
        public string Publisher { get; set; }

        [DeserializeAs(Name = "scan_type")]
        public string ScanType { get; set; }

        [DeserializeAs(Name = "series")]
        public string Series { get; set; }

        [DeserializeAs(Name = "sort_name")]
        public string SortName { get; set; }

        [DeserializeAs(Name = "summary")]
        public string Summary { get; set; }

        [DeserializeAs(Name = "title")]
        public string Title { get; set; }

        [DeserializeAs(Name = "Volume")]
        public string Volume { get; set; }

        public string CoverURL
        {
            set
            {

            }
            get
            {
                var url = string.Format("{0}/api/comics/{1}/pages/0/content.jpg", "http://10.0.2.2:7171", Id);
                return url;
            }
        }


        // Relationships - These must be maintained manually
        [DeserializeAs(Name = "credits")]
        [Ignore]
        public List<Credit> Credits { get; set; }

        [DeserializeAs(Name = "pages")]
        [Ignore]
        public List<Page> Pages { get; set; }
    }

    public class Credit
    {
        [DeserializeAs(Name = "id")]
        [PrimaryKey]
        public long Id { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "role")]
        public string Role { get; set; }
    }

    public class ComicCredit
    {
        public long ComicId { get; set; }
        public long CreditId { get; set; }
    }

    public class Page
    {
        [DeserializeAs(Name = "blocked")]
        public bool Blocked { get; set; }

        [DeserializeAs(Name = "deleted")]
        public bool Deleted { get; set; }

        [DeserializeAs(Name = "filename")]
        public string Filename { get; set; }

        [DeserializeAs(Name = "hash")]
        public string Hash { get; set; }

        [DeserializeAs(Name = "height")]
        public int Height { get; set; }

        [DeserializeAs(Name = "id")]
        [PrimaryKey]
        public int Id { get; set; }

        [DeserializeAs(Name = "index")]
        public int Index { get; set; }

        [DeserializeAs(Name = "page_type")]
        [Ignore]
        public PageType Type { get; set; }

        [DeserializeAs(Name = "width")]
        public int Width { get; set; }

        public long ComicId { get; set; }
    }

    public class PageType
    {
        [DeserializeAs(Name = "id")]
        public int Id { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }
    }
}
