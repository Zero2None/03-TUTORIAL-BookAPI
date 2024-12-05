﻿using BookAPI.Data;

namespace BookAPI.ViewModel
{
    public class BookVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //Da li smo pročitali knjigu
        public bool IsRead { get; set; }
        //datum kada smo ju pročitali (nullable Datetime - ako ju nismo pročitala datum
        //će //imati vrijednost null)
        public DateTime? DateRead { get; set; }
        //ocjena (nullable int - ako ju nismo pročitali ne možemo ju ocijeniti pa će
        //vrijednost biti null)
        public int? Rate { get; set; }
        public string Genre { get; set; }
        //public string Author { get; set; }
        public string CoverPictureURL { get; set; }
        public DateTime DateAdded { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public int PublihserId { get; set; }
        //više autora za istu knjigu  
        public List<int> AuthorIds { get; set; }
    }
}